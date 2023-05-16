using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HauptbuttonScript : MonoBehaviour
{
    public GameObject eingabefeld; // das GameObject, das das Textfeld enth�lt
    public GameObject kleinerButton; // das GameObject, das den kleineren Button enth�lt

    void Start()
    {
        eingabefeld.SetActive(false); // deaktiviere das Textfeld am Anfang
        kleinerButton.SetActive(false); // deaktiviere den kleineren Button am Anfang
    }

    public void ZeigeEingabefeld()
    {
        eingabefeld.SetActive(true); // aktiviere das Textfeld, wenn der Hauptbutton gedr�ckt wird
        kleinerButton.SetActive(true); // aktiviere den kleineren Button, wenn der Hauptbutton gedr�ckt wird
    }
}

