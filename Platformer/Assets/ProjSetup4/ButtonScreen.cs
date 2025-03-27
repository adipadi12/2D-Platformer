using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonScreen : MonoBehaviour
{
    Label label;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        label = root.Q<Label>("MyLabel");
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            label.style.backgroundColor = Color.black;
        }
    }
}
