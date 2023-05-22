using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
    public Toggle toggle;
    public GameObject[] elementsToToggle;

    private void Start()
    {
        if (toggle != null)
        {
            toggle.onValueChanged.AddListener(OnToggleValueChanged);
        }
    }

    private void OnToggleValueChanged(bool value)
    {
        foreach (GameObject element in elementsToToggle)
        {
            element.SetActive(value);
        }
    }
}

