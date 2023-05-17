using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    [SerializeField] AudioSource MusicPlay;
    void Update()
    {
        MusicPlay.volume = SoundValue.BackgroundMusic;
    }
}
