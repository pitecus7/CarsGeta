using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacterPanel : MonoBehaviour
{
    public EventHandler<byte> onSelectCharacter;
    public List<CharacterToSelectController> charactersToSelect;


    private void Start()
    {
        charactersToSelect.ForEach(each => each.onSelect += OnSelectCharacter);
    }

    private void OnSelectCharacter(object sender, byte e)
    {
        charactersToSelect.ForEach(each => { if (each.id != e) each.Deselect(); });
        onSelectCharacter(null, e);
    }

    public void SetupPanel(List<Character> characterList)
    {
        for (int i = 0; i < characterList.Count; i++)
        {
            if (i < charactersToSelect.Count && charactersToSelect[i] != null)
            {
                charactersToSelect[i].SetUpCharacterToSelect(characterList[i].id, characterList[i].speed, characterList[i].aceleration, characterList[i].control, characterList[i].nameChar);
            }
        }
    }
}
