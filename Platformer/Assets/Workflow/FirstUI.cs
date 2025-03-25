using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class FirstUI : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        UIDocument uiDocument = GetComponent<UIDocument>();
        if (uiDocument == null)
        {
            Debug.LogError("UIDocument not found!");
            return;
        }

        VisualElement root = uiDocument.rootVisualElement;
        if (root == null)
        {
            Debug.LogError("rootVisualElement is null!");
            return;
        }

        Button myButton = root.Q<Button>("Button");
        if (myButton == null)
        {
            Debug.LogError("Button not found in UI Document!");
            return;
        }
    }
    private void OnEnable()
    {
        UIDocument uiDocument = GetComponent<UIDocument>();
        VisualElement root = uiDocument.rootVisualElement;
        Button myButton = root.Q<Button>("Button");
        myButton.clicked += () => { Debug.Log("this is a functionality ig"); };
    }

}
