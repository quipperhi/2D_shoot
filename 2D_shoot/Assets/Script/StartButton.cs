using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    [SerializeField] Canvas MainCanvas;
    [SerializeField] Canvas LoadingCanvas;
    [SerializeField] Slider LoadingProgress;
    AsyncOperation async;
    void Start()
    {
        LoadingProgress.value = 0;
    }
    public void Gamestart()
    {
        GetComponent<Button>().interactable = false;
        StartLoading();
    }

    private void StartLoading()
    {
        
        MainCanvas.GetComponent<Animator>().Play("CanvasFadeOut");
        LoadingCanvas.GetComponent<Animator>().Play("CanvasFadeIn");
        Loading();
        async.allowSceneActivation = true;
    }

    private void Loading()
    {
        async = SceneManager.LoadSceneAsync("GameScene");
        async.allowSceneActivation = false;
        while(async.progress < 0.9f)
        {
            LoadingProgress.value = (float)async.progress;
        }
    }
}
