using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    [SerializeField] Scrollbar BackgroundMusicScrollbar;
    [SerializeField] Scrollbar SoundEffectScrollbar;
    [SerializeField] Text BackgroundMusicDisplayValue;
    [SerializeField] Text SoundEffectDisplayValue;
    void Start()
    {
        BackgroundMusicDisplayValue.text = (SoundValue.BackgroundMusic * 100).ToString();
        SoundEffectDisplayValue.text = (SoundValue.SoundEffect * 100).ToString();
    }

    void Update()
    {
        SetBackgroundMusicValue();
        SetSoundEffectValue();
    }

    private void SetBackgroundMusicValue()
    {
        BackgroundMusicDisplayValue.text = Mathf.Floor(SoundValue.BackgroundMusic * 100).ToString();
    }

    private void SetSoundEffectValue()
    {
        SoundEffectDisplayValue.text = Mathf.Floor(SoundValue.SoundEffect * 100).ToString();
    }

    public void GetBackgroundMusicValue (float Value)
    {
        SoundValue.BackgroundMusic = BackgroundMusicScrollbar.value;
    }

    public void GetSoundEffectValue (float Value)
    {
        SoundValue.SoundEffect = SoundEffectScrollbar.value;
    }
}
