using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderIndicator : MonoBehaviour
{
    [SerializeField] private int SliderID;
    [SerializeField] private Slider slider;
    [SerializeField] private Text text;

    public void NewValue()
    {
        text.text = slider.value.ToString();
        switch(SliderID)
        {
            case 21: GameInfo.numberOfPeople = (int)(slider.value); break;
            case 22: GameInfo.numberOfPlayer = (int)(slider.value); break;
            case 31: GameInfo.worldview = (int)(slider.value); break;
            case 32: GameInfo.greed = (int)(slider.value); break;
            case 33: GameInfo.forgiveness = (int)(slider.value); break;
            case 34: GameInfo.revenge = (int)(slider.value); break;

        }
    }
}
