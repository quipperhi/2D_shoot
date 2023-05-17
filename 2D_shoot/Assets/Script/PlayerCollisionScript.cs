using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    [SerializeField] PlayerScript playerscript;
    [SerializeField] GameObject Explosion;
    [SerializeField] AudioClip GetHitSound;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Enemy")
        {
            playerscript.lifescript.GetHit();
            Instantiate(Explosion, collider.transform.position, collider.transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(GetHitSound, SoundValue.SoundEffect);
            Destroy(collider.gameObject);
        }
    }
}
