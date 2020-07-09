using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettingsPanel : MonoBehaviour
{
    public EventHandler<Maps> onMapSelect;
    public EventHandler<Difficulty> onDifficultySelect;
    public EventHandler<GameMode> onGameModeSelect;

    public List<Sprite> spritesMaps = new List<Sprite>();

    public Image mapImage;

    public Dropdown difficulty;

    public Dropdown gameMode;

    private int mapSelect = 0;

    private void Start()
    {
        difficulty.onValueChanged.AddListener(DifficultyChanged);
        gameMode.onValueChanged.AddListener(gameModeChanged);
    }

    private void gameModeChanged(int value)
    {
        if (value == 0)
        {
            if (onGameModeSelect != null)
                onGameModeSelect(null, GameMode.Laps);
        }
        else
        {
            if (onGameModeSelect != null)
                onGameModeSelect(null, GameMode.TimeLimit);
        }
    }

    public void DifficultyChanged(int value)
    {
        if (onDifficultySelect != null)
            onDifficultySelect(null, (Difficulty)value);
    }

    public void NextMap()
    {
        if (mapSelect + 1 < spritesMaps.Count)
        {
            mapSelect++;
        }
        else
        {
            mapSelect = 0;
        }

        mapImage.sprite = spritesMaps[mapSelect];
        if (onMapSelect != null)
            onMapSelect(null, (Maps)mapSelect);
    }

    public void PreviusMap()
    {
        if (mapSelect - 1 >= 0)
        {
            mapSelect--;
        }
        else
        {
            mapSelect = spritesMaps.Count - 1;
        }
        mapImage.sprite = spritesMaps[mapSelect];
    }
}
