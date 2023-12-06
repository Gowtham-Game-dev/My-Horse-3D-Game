using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip audioclip;


    public void HorseSteps()
    {
        audiosource.clip= audioclip;
        audiosource.Play();
    }
    
}
