using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletFire : MonoBehaviour
{
    [SerializeField] PlayerScript playerscript;
    [SerializeField] Transform bullet;
    [SerializeField] Transform BulletFirePoint;
    [SerializeField] AudioClip BulletSound;
    private float FireCoolDownTime = 0.3f;
    private float FireCoolDownTimeCount;
    
    void Start()
    {
        FireCoolDownTimeCount = FireCoolDownTime;
    }

    void Update()
    {
        FireCoolDownTimeCount += 1f * Time.deltaTime;
        if(playerscript.inputscript.isSpacePressed && CanFire())
        {
            Fire();
        }
    }

    private bool CanFire()
    {
        return FireCoolDownTimeCount >= FireCoolDownTime;
    }

    private void Fire()
    {
        FireCoolDownTimeCount = 0f;
        GetComponent<AudioSource>().PlayOneShot(BulletSound, SoundValue.SoundEffect);
        Instantiate(bullet, BulletFirePoint.position, BulletFirePoint.rotation);
    }
}
