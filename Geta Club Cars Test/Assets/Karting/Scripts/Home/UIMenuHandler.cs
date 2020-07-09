using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenuHandler : MonoBehaviour
{
    public EventHandler onGoToPlay;

    public GameObject homeMenuPanel;

    public GameObject controlsPanel;

    public SelectCharacterPanel selectCharacterPanel;

    public GameSettingsPanel gameSettingsPanel;

    public KartDisplay kartDisplay;


    public void OpenHomeMenu()
    {
        CloseAllPanels();
        homeMenuPanel.SetActive(true);
        kartDisplay.ChangeToMenu();
    }

    public void OpenSelectCharacterPAnel()
    {
        CloseAllPanels();
        selectCharacterPanel.gameObject.SetActive(true);
        kartDisplay.ChangeToSelectCharacter();
    }

    public void OpenGameSettingsPanel()
    {
        CloseAllPanels();
        gameSettingsPanel.gameObject.SetActive(true);
        kartDisplay.Hide();
    }

    public void GoToPlay()
    {
        if (onGoToPlay != null)
            onGoToPlay(null, null);
    }

    public void CloseAllPanels()
    {
        homeMenuPanel.SetActive(false);
        controlsPanel.SetActive(false);
        selectCharacterPanel.gameObject.SetActive(false);
        gameSettingsPanel.gameObject.SetActive(false);
    }
}
