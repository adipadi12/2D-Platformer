using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonScreen : MonoBehaviour
{
    VisualElement element;
    VisualElement child;
    Slider slider;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // element = root.Q("Box");
        element = root.Q("Container");
        slider = root.Q<Slider>("MySlider");

        slider.RegisterCallback<ChangeEvent<float>>(OnSliderChanged); //subscribing to this event


        VisualTreeAsset template = Resources.Load<VisualTreeAsset>("Box");

        VisualElement card = template.Instantiate();
        element.Add(card);

        //loasding image
        Sprite img = Resources.Load<Sprite>("img/nature bg.png");
        VisualElement avatar = card.Q("Avatar");
        avatar.style.backgroundImage = new StyleBackground(img);
    }

    void OnSliderChanged(ChangeEvent<float> evt)
    {
        element.style.width = evt.newValue; //takes the float of the slider value as an argument and passes into width field to alter
        element.Add(child);
    }

}
