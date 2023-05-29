using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderScript : MonoBehaviour
{

    [SerializeField] private Slider _slider;

    [SerializeField] private TextMeshProUGUI _numberSlider;


    void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            _numberSlider.text = v.ToString("0");
        });
    }
}
