using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonScreen : MonoBehaviour
{
    VisualElement element;
    Slider slider;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        element = root.Q("Box");
        slider = root.Q<Slider>("MySlider");

        slider.RegisterCallback<ChangeEvent<float>>(OnSliderChanged); //subscribing to this event
    }

    void OnSliderChanged(ChangeEvent<float> evt)
    {
        element.style.width = evt.newValue; //takes the float of the slider value as an argument and passes into width field to alter
    }
    
}
