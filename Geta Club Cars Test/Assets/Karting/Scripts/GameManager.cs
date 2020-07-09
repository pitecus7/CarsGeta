using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public List<Character> characters;

    public UserInformation userInfo;

    public GameModeInformation gameInformation;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("characterIdSelected"))
        {
            userInfo.charaterIdSelected = (byte)PlayerPrefs.GetInt("characterIdSelected");
        }
        else
        {
            userInfo.charaterIdSelected = 0;
        }

        if (Instance == null) //Android
        {
            Instance = this;
        }
        if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void GoToGameplay()
    {
        SceneManager.LoadSceneAsync("Loading", LoadSceneMode.Additive);
    }
}
