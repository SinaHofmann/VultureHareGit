using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectRunning : MonoBehaviour
{
    public AudioClip RunningClip;

    public AudioSource RunningSource;
    // Start is called before the first frame update
    void Start()
    {
        RunningSource.clip = RunningClip;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        RunningSource.Play();

         if(Input.GetKeyDown(KeyCode.D))
        RunningSource.Play();
    }
}
