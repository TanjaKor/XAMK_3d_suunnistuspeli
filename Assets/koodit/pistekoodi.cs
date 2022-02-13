using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pistekoodi : MonoBehaviour
{
    //m‰‰ritell‰‰n ajan laskuri
    private float aikalaskuri = 0f;

    //m‰‰ritell‰‰‰n lˆydetyille ankoille muuttuja
    public int kompassit = 0;

    //luodaan tekstikentille muuttujat
    public GameObject aika = null;
    public GameObject pisteet = null;    
    
    void Update()
    {   
        // ajan lasku
        this.aikalaskuri += Time.deltaTime;
        this.aika.GetComponent<Text>().text = "AIKA: " + this.aikalaskuri.ToString("0") + "s";

        //kompassien lasku
        this.pisteet.GetComponent<Text>().text = "KOMPASSIT: " + this.kompassit +"/5";

        //siirryt‰‰n gameoversceneen kun kaikki kompassit lˆytyneet
        if (this.kompassit == 5)
        {
            PlayerPrefs.SetFloat("aika", this.aikalaskuri);
            SceneManager.LoadScene("gameoverskene");
        }
    } //update
} // class
