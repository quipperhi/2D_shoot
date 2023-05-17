using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTotal : MonoBehaviour
{
    [SerializeField] BackgroundScript backgroundscript;
    [SerializeField] Text UIScore1;
    [SerializeField] Text UIScore2;
    private static int ScoreNum;
    
    void Start()
    {
        ScoreNum = 0;
    }

    void Update()
    {
        UIScore1.text = "Score:" + ScoreNum;
        UIScore2.text = "Score:" + ScoreNum;
    }

    public void AddPoint(int point)
    {
        ScoreNum += point;
    }

    public int GetScore()
    {
        return ScoreNum;
    }
}
