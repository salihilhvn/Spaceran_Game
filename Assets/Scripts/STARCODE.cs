using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STARCODE : MonoBehaviour
{
    public AudioSource tickSound;
    void Start()
    {
    }
    public void OnTriggerEnter(Collider other)
    {
        scoresystem.score += 1;

        gameObject.SetActive(false);
        tickSound.Play();
    }
}