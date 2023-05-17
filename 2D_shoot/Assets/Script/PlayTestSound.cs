using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayTestSound : MonoBehaviour, IPointerUpHandler
{
    [SerializeField] AudioClip TestSound;
    public void OnPointerUp(PointerEventData eventData)
    {
        playTestSound();
    }
    public void playTestSound()
    {
        GetComponent<AudioSource>().PlayOneShot(TestSound, SoundValue.SoundEffect);
    }
}
