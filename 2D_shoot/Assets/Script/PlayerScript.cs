using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] internal PlayerInputScript inputscript;
    [SerializeField] internal PlayerMovementScript movementscript;
    [SerializeField] internal PlayerCollisionScript collisionscript;
    [SerializeField] internal PlayerBulletFire bulletfirescript;
    [SerializeField] internal PlayerLife lifescript;
    internal Rigidbody2D rb2d;
    internal Animator anim;


    internal float movespeed = 10f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
}
