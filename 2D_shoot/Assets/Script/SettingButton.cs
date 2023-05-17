using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{
    [SerializeField] GameObject SettingWindow;
    [SerializeField] Scrollbar BackgroundMusicScrollbar;
    [SerializeField] Scrollbar SoundEffectScrollbar;
    public void SettingWindowActive()
    {
        SettingWindow.SetActive(true);
        BackgroundMusicScrollbar.value = SoundValue.BackgroundMusic;
        SoundEffectScrollbar.value = SoundValue.SoundEffect;
        Time.timeScale = 0;
    }
}
