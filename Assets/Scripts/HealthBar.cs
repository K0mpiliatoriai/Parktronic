using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    void Start()
    {
        slider.maxValue = 6;
        slider.value = 6;
        fill.color = gradient.Evaluate(1f);
    }


    public void SetHeath(int health)
    {
        slider.value -= health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        if (slider.value == 0)
        {
            CarManager.IsGameFailed = true;
        }

    }
}
