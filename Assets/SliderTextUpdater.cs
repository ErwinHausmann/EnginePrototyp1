using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderTextUpdater : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public UnityEngine.UI.Slider slider;

    private void Start()
    {
        // F�ge einen Listener hinzu, der auf �nderungen des Slider-Werts reagiert
        slider.onValueChanged.AddListener(UpdateText);
    }

    private void UpdateText(float value)
    {
        // Aktualisiere den Text mit dem aktuellen Slider-Wert
        textMeshPro.text = value.ToString();
    }
}

