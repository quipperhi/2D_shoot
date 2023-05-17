using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyCollision : MonoBehaviour
{
    [SerializeField] GameObject Explosion;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Bullet" || collider.gameObject.tag == "Rocket")
        {
            GameObject.Find("BG").GetComponent<ScoreTotal>().AddPoint(1); // 加分
            Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
    }
}
