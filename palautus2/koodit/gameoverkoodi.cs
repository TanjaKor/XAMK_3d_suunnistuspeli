using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverkoodi : MonoBehaviour
{

    void Start()
    {
        //haetaan kulunut aika
        float aika1 = PlayerPrefs.GetFloat("aika");
        GameObject.Find("gameoverteksti").GetComponent<Text>().text = "Aikaa kului: " + aika1.ToString("0") + "s";
    } //start
} //class
