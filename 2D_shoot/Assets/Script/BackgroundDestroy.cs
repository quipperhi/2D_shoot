using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDestroy : MonoBehaviour
{
    private bool SendGenerationFlagYet = true;
    void Update()
    {
        float CameraPositionX = GameObject.Find("Main Camera").GetComponent<CameraFollow>().GetPosition().x;
        float BackgroundSizeX = transform.GetComponent<Renderer>().bounds.size.x;

        if((CameraPositionX - transform.position.x) > 0f && SendGenerationFlagYet)
        {
            SendGenerationFlagYet = false;
            GameObject.Find("BG").GetComponent<BackgroundGeneration>().SetGenerationFlag();
        }

        if((CameraPositionX - transform.position.x) > (BackgroundSizeX + 5f))
        {
            Destroy(gameObject);
        }
    }
}
