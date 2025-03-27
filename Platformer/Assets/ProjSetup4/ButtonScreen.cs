using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonScreen : MonoBehaviour
{
    VisualElement box;
    Button myButton;
    private void OnEnable()
    {
        UIDocument ui = GetComponent<UIDocument>();
        VisualElement root = ui.rootVisualElement; //accesses the root inside the UXML file

        box = root.Q("Box"); //gets references to element in our layout
        myButton = root.Q<Button>("MyButton");

        myButton.clicked += OnButtonClicked; //subscribing to this
    }

    void OnButtonClicked()
    {
        int randomWidth = Random.Range(50, 300);

        box.style.width = randomWidth; //getting the style to randomize on button being clicked
        box.style.height = randomWidth;
    }
}
