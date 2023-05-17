using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    [SerializeField] PlayerScript playerscript;

    internal bool isLeftPressed;
    internal bool isRightPressed;
    internal bool isUpPressed;
    internal bool isDownPressed;
    internal bool isSpacePressed;
    internal bool isCtrlPressed;

    void Start()
    {
        Debug.Log("PlayerInputScript Starting");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            isLeftPressed = true;
        }
        else
        {
            isLeftPressed = false;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            isRightPressed = true;
        }
        else
        {
            isRightPressed = false;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            isUpPressed = true;
        }
        else
        {
            isUpPressed = false;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            isDownPressed = true;
        }
        else
        {
            isDownPressed = false;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            isSpacePressed = true;
        }
        else
        {
            isSpacePressed = false;
        }
    }
}
