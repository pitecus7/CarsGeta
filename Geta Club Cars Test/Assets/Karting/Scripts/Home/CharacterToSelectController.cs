using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterToSelectController : MonoBehaviour
{
    public EventHandler<byte> onSelect;

    public byte id;

    public Text nameCharacterText;

    public Slider velocitySlider;
    public Slider acelerationSlider;
    public Slider controlSlider;

    public GameObject selector;

    public void SetUpCharacterToSelect(byte id, float speed, float aceleration, float control, string name)
    {
        this.id = id;

        nameCharacterText.text = name;

        velocitySlider.maxValue = 30;
        acelerationSlider.maxValue = 30;
        controlSlider.maxValue = 30;

        velocitySlider.value = speed;
        acelerationSlider.value = aceleration;
        controlSlider.value = control;
    }

    public void Select()
    {
        selector.gameObject.SetActive(true);
        if (onSelect != null)
        {
            onSelect(null, id);
        }
    }

    public void Deselect()
    {
        selector.gameObject.SetActive(false);
    }
}
