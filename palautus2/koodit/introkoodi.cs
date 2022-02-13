using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class introkoodi : MonoBehaviour
{
    void Start()
    {
        //Jatketaan intron musiikkia tauotta
        DontDestroyOnLoad(GameObject.Find("aaniolio"));
    } // start

    void Update()
    {
        // Peliin p‰‰see mill‰ n‰pp‰imell‰ tahansa
        if (Input.anyKey)
        {
            SceneManager.LoadScene("SampleScene");
        } // if
    } // update
} //class
