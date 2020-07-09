using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartDisplay : MonoBehaviour
{
    public Vector3 homeMenuPosition;
    public Vector3 homeMenuRotation;

    public Vector3 SelectCharacterPosition;
    public Vector3 SelectCharacterRotation;

    public SkinnedMeshRenderer meshRenderer;

    public void Start()
    {
    }
    public void ChangeToMenu()
    {
        gameObject.SetActive(true);
        transform.position = homeMenuPosition;
        transform.eulerAngles = homeMenuRotation;
    }

    public void ChangeToSelectCharacter()
    {
        gameObject.SetActive(true);
        transform.position = SelectCharacterPosition;
        transform.eulerAngles = SelectCharacterRotation;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void ChangeColor(Color color)
    {
        meshRenderer.material.color = color;
    }

    private void Update()
    {

    }

}
