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
        // pyöritetään kompassia
        this.GetComponent<Transform>().Rotate(0f, 15f * Time.deltaTime, 0f);
    } //update
    private void OnTriggerEnter(Collider other)
    {
        //onko törmääjä pantteri?
        if (other.name.Equals("pelaaja"))
        {
            //merkkiääni löytymisen merkiksi
            GameObject.Find("aaniolio2").GetComponent<AudioSource>().Play();
            Debug.Log("Jee, löysit yhden!");
            //päivitetään piste-laskuri
            GameObject.Find("koodivarasto").GetComponent<pistekoodi>().kompassit++;
            //tuhotaan kompassi
            Destroy(this.gameObject);
        }
    }
} //class
