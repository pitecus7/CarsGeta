using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty
{
    easy,
    normal,
    hard
}

public enum Maps
{
    Map1,
    Map2,
    Map3,
    Map4
}

[Serializable]
public class UserInformation
{
    public byte charaterIdSelected;
}
[Serializable]
public class GameModeInformation
{
    public GameMode gameMode;
    public Maps map;
    public Difficulty difficulty;
}
