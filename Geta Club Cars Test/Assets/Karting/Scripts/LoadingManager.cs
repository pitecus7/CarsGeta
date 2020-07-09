using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    void Start()
    {
        if (GameManager.Instance != null)
        {
            SceneManager.LoadSceneAsync("MainScene");
        }
    }

    private void onCompleteLoadMap(AsyncOperation obj)
    {
    }

    private void onCompleteMainScene(AsyncOperation obj)
    {
        if (SceneManager.GetSceneByName("IntroMenu").isLoaded == true)
        {
            SceneManager.UnloadSceneAsync("IntroMenu");
        }

        if (SceneManager.GetSceneByName("Loading").isLoaded == true)
        {
            SceneManager.UnloadSceneAsync("Loading");
        }
    }
}
