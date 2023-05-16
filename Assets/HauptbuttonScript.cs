using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HauptbuttonScript : MonoBehaviour
{
    public GameObject eingabefeld; // das GameObject, das das Textfeld enthält
    public GameObject kleinerButton; // das GameObject, das den kleineren Button enthält

    void Start()
    {
        eingabefeld.SetActive(false); // deaktiviere das Textfeld am Anfang
        kleinerButton.SetActive(false); // deaktiviere den kleineren Button am Anfang
    }

    public void ZeigeEingabefeld()
    {
        eingabefeld.SetActive(true); // aktiviere das Textfeld, wenn der Hauptbutton gedrückt wird
        kleinerButton.SetActive(true); // aktiviere den kleineren Button, wenn der Hauptbutton gedrückt wird
    }
}

