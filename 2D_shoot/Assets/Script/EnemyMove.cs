using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float XMoveSpeed = 2f;
    private float YMoveSpeed = 2.5f;
    private float YPosTarget;
    private float RandomNum;
    private bool isYPosSetTarget = false;

    void Start()
    {
        YPosSetTarget();
    }
    void Update()
    {
        YPosArriveTarget();

        if(isYPosSetTarget)
        {
            Movement();
        }
        else
        {
            isYPosSetTarget = true;
            YPosSetTarget();
        }
    }

    private void YPosSetTarget()
    {
        YPosTarget = Random.Range(8f, -8f);
        if(Mathf.Abs(YPosTarget - transform.position.y) < 5f)
        {
            isYPosSetTarget = false;
        }
        RandomNum = Random.Range(0.1f, 0.7f);
    }

    private void YPosArriveTarget()
    {
        isYPosSetTarget = Mathf.Abs(transform.position.y - YPosTarget) > RandomNum;
    }

    private void Movement()
    {
        float NewXPos = transform.position.x - XMoveSpeed * Time.deltaTime;
        float NewYPos = Mathf.Lerp(transform.position.y, YPosTarget, YMoveSpeed * Time.deltaTime);

        transform.position = new Vector2(NewXPos, NewYPos);
    }
}
