using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is in charge of managing HOME.
/// </summary>
public class HomeManager : MonoBehaviour
{
    public UIMenuHandler UIHandler;

    private void Start()
    {
        if (UIHandler != null && GameManager.Instance != null)
        {
            UIHandler.selectCharacterPanel.onSelectCharacter += ChangeMainCharacter;
            ChangeMainCharacter(null, GameManager.Instance.userInfo.charaterIdSelected);
            UIHandler.selectCharacterPanel.SetupPanel(GameManager.Instance.characters);
            UIHandler.gameSettingsPanel.onMapSelect += OnMapSelect;
            UIHandler.gameSettingsPanel.onDifficultySelect += OnDifficultySelected;
            UIHandler.gameSettingsPanel.onGameModeSelect += OnGameModeSelected;
            UIHandler.onGoToPlay += GoToGameplay;
        }
    }

    /// <summary>
    /// this a call when user change game mode.
    /// </summary>
    /// <param name="sender">Who send it</param>
    /// <param name="e">Game mode to change</param>
    private void OnGameModeSelected(object sender, GameMode e)
    {
        GameManager.Instance.gameInformation.gameMode = e;
    }

    private void OnDifficultySelected(object sender, Difficulty e)
    {
        GameManager.Instance.gameInformation.difficulty = e;
    }

    private void OnMapSelect(object sender, Maps e)
    {
        GameManager.Instance.gameInformation.map = e;
    }

    private void GoToGameplay(object sender, EventArgs e)
    {
        GameManager.Instance.GoToGameplay();
    }

    private void ChangeMainCharacter(object sender, byte e)
    {
        UIHandler.kartDisplay.ChangeColor(GameManager.Instance.characters[(int)e].color);
        GameManager.Instance.userInfo.charaterIdSelected = e;
        PlayerPrefs.SetInt("characterIdSelected", (int)e);
    }

    private void OnDestroy()
    {
        UIHandler.selectCharacterPanel.onSelectCharacter -= ChangeMainCharacter;
        UIHandler.gameSettingsPanel.onMapSelect -= OnMapSelect;
        UIHandler.gameSettingsPanel.onDifficultySelect -= OnDifficultySelected;
        UIHandler.onGoToPlay -= GoToGameplay;
    }
}
