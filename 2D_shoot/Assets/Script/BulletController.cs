using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float BulletMoveSpeed = 25f;
    void Update()
    {
        transform.Translate(BulletMoveSpeed * Time.deltaTime, 0, 0);
        Destroy(gameObject, 2f);
    }
}
