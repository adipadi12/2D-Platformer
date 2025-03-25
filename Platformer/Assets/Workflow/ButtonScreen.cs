using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonScreen : MonoBehaviour
{
    private void OnEnable()
    {
        UIDocument ui = GetComponent<UIDocument>();
        VisualElement root = ui.rootVisualElement;

        Button button = root.Q<Button>("MyButton");
        button.RegisterCallback<ClickEvent>(elem => button.style.backgroundColor = Color.yellow);
        Debug.Log
            ("Nigga");
    }
}
