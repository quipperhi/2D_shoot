using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{
    [SerializeField] BackgroundScript backgroundscript;
    [SerializeField] GameObject Enemy;
    private Vector3 CameraPosition;
    private float BackgroundSizeX;

    private float EnemyGenerationXPosition;
    private int GenerateTime;
    private int GenerateAmount;
    private int LastTime;
    private int CurrentTime;
    private bool WaitNextSecond = false;


    void Start()
    {
        GenerateTime = 3;
        GenerateAmount = 7;
    }

    void Update()
    {
        GetCurrentTime();
        GetEnemyGenerationXPosition();
        GenerateOnce();
        DifficultyRises();

        if(CurrentTime % GenerateTime == 0 && !WaitNextSecond)
        {
            Generate(GenerateAmount);
        }
    }

    private void GetCurrentTime()
    {
        CurrentTime = GameObject.Find("BG").GetComponent<Timer>().GetTime();
    }

    private void DifficultyRises()
    {
        switch(CurrentTime/10)
        {
            case 5:
            {
                GenerateTime = 3;
                GenerateAmount = 8;
                break;
            }
            case 4:
            {
                GenerateTime = 3;
                GenerateAmount = 9;
                break;
            }
            case 3:
            {
                GenerateTime = 2;
                GenerateAmount = 8;
                break;
            }
            case 2:
            {
                GenerateTime = 2;
                GenerateAmount = 9;
                break;
            }
            default:
            {
                break;
            }
        }
    }

    private void GenerateOnce()
    {
        if(LastTime != GameObject.Find("BG").GetComponent<Timer>().GetTime())
        {
            WaitNextSecond = false;
        }
        LastTime = GameObject.Find("BG").GetComponent<Timer>().GetTime();
    }

    private void Generate(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            Vector2 GeneratePosition = new Vector2(Random.Range(EnemyGenerationXPosition, EnemyGenerationXPosition + 10f), Random.Range(-7f, 7f));
            Instantiate(Enemy, GeneratePosition, Quaternion.Euler(0, 0, 0));
        }
        WaitNextSecond = true;
    }

    private void GetEnemyGenerationXPosition()
    {
        CameraPosition = GameObject.Find("Main Camera").GetComponent<CameraFollow>().GetPosition();
        BackgroundSizeX = GameObject.Find("BG").GetComponent<BackgroundGeneration>().GetBackgroundSizeX();
        EnemyGenerationXPosition = CameraPosition.x + BackgroundSizeX;
    }
}
