using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kompassikoodi : MonoBehaviour
{
    void Start()
    {
        
    } //start
  
    // Update is called once per frame
    void Update()
    {
        // py�ritet��n kompassia
        this.GetComponent<Transform>().Rotate(0f, 15f * Time.deltaTime, 0f);
    } //update
    private void OnTriggerEnter(Collider other)
    {
        //onko t�rm��j� pantteri?
        if (other.name.Equals("pelaaja"))
        {
            //merkki��ni l�ytymisen merkiksi
            GameObject.Find("aaniolio2").GetComponent<AudioSource>().Play();
            Debug.Log("Jee, l�ysit yhden!");
            //p�ivitet��n piste-laskuri
            GameObject.Find("koodivarasto").GetComponent<pistekoodi>().kompassit++;
            //tuhotaan kompassi
            Destroy(this.gameObject);
        }
    }
} //class
