using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] BackgroundScript backgroundscript;
    [SerializeField] Text TimeUI1;
    [SerializeField] Text TimeUI2;
    private int timer = 60;
    private bool timerStart = true;

    // Update is called once per frame
    void Update()
    {
        TimeUI1.text = "Time : " + timer.ToString();
        TimeUI2.text = "Time : " + timer.ToString();

        if(timerStart)
        {
            StartCoroutine("TimerCountDown");
            timerStart = false;
        }
    }

    IEnumerator TimerCountDown()
    {
        yield return new WaitForSeconds(1);
        timer--;
        if(timer < 0)
        {
            GameEnd();
        }
        timerStart = true;
    }

    public void GameEnd()
    {
        ScoreBoard.FinalScore = GameObject.Find("BG").GetComponent<ScoreTotal>().GetScore();
        SceneManager.LoadScene("EndScene");
    }

    public int GetTime()
    {
        return timer;
    }
}
