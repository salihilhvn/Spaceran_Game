using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    [SerializeField]
    AudioClip AudioClip;

    AudioSource AudioSource;
    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        AudioSource.loop = false;
        AudioSource.clip = AudioClip;

    }
    public void ApplyCollisionEffect()
    {
        AudioSource.Play();
    }
}
