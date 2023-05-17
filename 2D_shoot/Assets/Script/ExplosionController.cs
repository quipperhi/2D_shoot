using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    [SerializeField] AudioClip ExplosionSound;

    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(ExplosionSound, SoundValue.SoundEffect);
        Destroy(gameObject, Random.Range(0.4f, 0.7f));
    }
}
