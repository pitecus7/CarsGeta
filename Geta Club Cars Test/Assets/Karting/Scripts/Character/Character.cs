using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create Character/Character")]
public class Character : ScriptableObject
{
    public Color color; //Color or 3d Object to create;.

    public byte id;

    public float aceleration;
    public float speed;
    public float control;

    public string nameChar;
}
