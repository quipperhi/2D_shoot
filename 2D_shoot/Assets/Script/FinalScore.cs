using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    [SerializeField] Text FinalScoreUI1;
    [SerializeField] Text FinalScoreUI2;
    private int finalscore;

    void start()
    {
        // finalscore = ScoreBoard.FinalScore;
    }

    void Update()
    {
        finalscore = ScoreBoard.FinalScore;
        FinalScoreUI1.text =  "Score:" + finalscore;
        FinalScoreUI2.text =  "Score:" + finalscore;
    }
}
