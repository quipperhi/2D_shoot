using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGeneration : MonoBehaviour
{
    [SerializeField] BackgroundScript backgroundscript;
    [SerializeField] GameObject background1;
    [SerializeField] GameObject background2;
    [SerializeField] Transform MainCamera;

    private bool GenerationFlag = false;

    private int count = 1;

    private float BackgroundSizeX;
    void Start()
    {
        BackgroundSizeX = background1.GetComponent<Renderer>().bounds.size.x;
        Instantiate(background1, MainCamera.position + new Vector3(0, 0, 10), MainCamera.rotation);
        count += 1;
    }

    void Update()
    {
        if(GenerationFlag)
        {
            GenerationBackground();
        }
    }

    public void SetGenerationFlag()
    {
        GenerationFlag = true;
    }

    public float GetBackgroundSizeX()
    {
        return BackgroundSizeX;
    }

    private void GenerationBackground()
    {
        if(count % 2 == 0)
        {
            Instantiate(background2, new Vector3(MainCamera.position.x + BackgroundSizeX - 0.2f, MainCamera.position.y, MainCamera.position.z + 10f), MainCamera.rotation);
        }
        else
        {
            Instantiate(background1, new Vector3(MainCamera.position.x + BackgroundSizeX - 0.2f, MainCamera.position.y, MainCamera.position.z + 10f), MainCamera.rotation);
        }
        GenerationFlag = false;
        count += 1;
    }

    
}
