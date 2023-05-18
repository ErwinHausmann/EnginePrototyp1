using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoterSlider : MonoBehaviour
{
    public Slider slider;
    public GameObject panel;

    private bool isFirstValueChanged = false;

    private void Start()
    {
        slider.onValueChanged.AddListener(OnSliderValueChanged);
        panel.SetActive(false);
    }

    private void OnSliderValueChanged(float value)
    {
        if (!isFirstValueChanged)
        {
            isFirstValueChanged = true;
            return;
        }

        // Hier können Sie den Wert des Sliders verwenden, um die gewünschte Aktion auszuführen
        // Zum Beispiel: Aktivieren oder deaktivieren Sie das Panel basierend auf dem Slider-Wert

        if (value == 5)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }
}





