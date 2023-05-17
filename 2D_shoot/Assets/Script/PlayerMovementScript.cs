using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] PlayerScript playerscript;
    void Update()
    {
        MovewithCamera();

        if (playerscript.inputscript.isLeftPressed)
        {
            MovePlayerLeft();
        }

        if (playerscript.inputscript.isRightPressed)
        {
            MovePlayerRight();
        }

        if (playerscript.inputscript.isUpPressed)
        {
            MovePlayerUp();
        }

        if (playerscript.inputscript.isDownPressed)
        {
            MovePlayerDown();
        }
    }

    private void MovePlayerLeft()
    {
        playerscript.transform.position = new Vector2(transform.position.x - playerscript.movespeed * Time.deltaTime, transform.position.y);
    }

    private void MovePlayerRight()
    {
        playerscript.transform.position = new Vector2(transform.position.x + playerscript.movespeed * Time.deltaTime, transform.position.y);
    }

    private void MovePlayerUp()
    {
        playerscript.transform.position = new Vector2(transform.position.x, transform.position.y + playerscript.movespeed * Time.deltaTime);
    }

    private void MovePlayerDown()
    {
        playerscript.transform.position = new Vector2(transform.position.x, transform.position.y - playerscript.movespeed * Time.deltaTime);
    }

    private void MovewithCamera()
    {
        transform.position = new Vector2(transform.position.x + CameraFollow.CameraSpeed * Time.deltaTime, transform.position.y);
    }
}
