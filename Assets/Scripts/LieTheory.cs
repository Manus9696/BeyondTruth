﻿using System.Collections;          
using UnityEngine;
using UnityEngine.SceneManagement;

public class LieTheory : MonoBehaviour
{           
    public Animator fader;     
                                                       
    void Start()
    {
        fader = fader.gameObject.GetComponent<Animator>();
        StartCoroutine(PlayPuller());
    }    

    IEnumerator PlayPuller()
    {
        yield return new WaitForSeconds(12f); 
        yield return StartCoroutine(SetTrigger());
    }

    IEnumerator SetTrigger()
    {
        fader.SetBool("Fade", true);
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("Solitude");
    }
}
