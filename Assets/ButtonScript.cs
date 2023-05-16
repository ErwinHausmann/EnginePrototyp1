using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject eingabefeld; // das GameObject, das das Textfeld enth�lt
    public GameObject kleinerButton; // das GameObject, das den kleineren Button enth�lt
    public GameObject jaButton; // das GameObject, das den "Ja"-Button enth�lt
    public GameObject neinButton; // das GameObject, das den "Nein"-Button enth�lt
    public GameObject textField; // das GameObject, das das Textfeld enth�lt
    public GameObject image; // das GameObject, das das Bild enth�lt
    public GameObject slider; // das GameObject, das den Slider enth�lt
    public GameObject closeButton; // das GameObject, das den Schlie�en-Button enth�lt

    void Start()
    {
        eingabefeld.SetActive(false); // deaktiviere das Textfeld am Anfang
        kleinerButton.SetActive(false); // deaktiviere den kleineren Button am Anfang
        jaButton.SetActive(false); // deaktiviere den "Ja"-Button am Anfang
        neinButton.SetActive(false); // deaktiviere den "Nein"-Button am Anfang
        textField.SetActive(false); // deaktiviere das Textfeld am Anfang
        image.SetActive(false); // deaktiviere das Bild am Anfang
        slider.SetActive(false); // deaktiviere den Slider am Anfang
        closeButton.SetActive(false); // deaktiviere den Schlie�en-Button am Anfang
    }

    public void ZeigeEingabefeld()
    {
        eingabefeld.SetActive(true); // aktiviere das Textfeld, wenn der Hauptbutton gedr�ckt wird
        kleinerButton.SetActive(true); // aktiviere den kleineren Button, wenn der Hauptbutton gedr�ckt wird
    }

    public void ZeigeButtons()
    {
        jaButton.SetActive(true); // aktiviere den "Ja"-Button, wenn der Hauptbutton gedr�ckt wird
        neinButton.SetActive(true); // aktiviere den "Nein"-Button, wenn der Hauptbutton gedr�ckt wird
        textField.SetActive(false); // deaktiviere das Textfeld, wenn der Hauptbutton gedr�ckt wird
        image.SetActive(false); // deaktiviere das Bild, wenn der Hauptbutton gedr�ckt wird
        slider.SetActive(false); // deaktiviere den Slider, wenn der Hauptbutton gedr�ckt wird
        closeButton.SetActive(false); // deaktiviere den Schlie�en-Button, wenn der Hauptbutton gedr�ckt wird
    }

    public void JaGedrueckt()
    {
        // hier k�nnen Sie Code einf�gen, der ausgef�hrt wird, wenn der "Ja"-Button gedr�ckt wird
        Debug.Log("Der Ja-Button wurde gedr�ckt!");
        jaButton.SetActive(false); // deaktiviere den "Ja"-Button
        neinButton.SetActive(false); // deaktiviere den "Nein"-Button
        textField.SetActive(false); // deaktiviere das Textfeld
        image.SetActive(true); // aktiviere das Bild
        slider.SetActive(false); // deaktiviere den Slider
        closeButton.SetActive(false); // deaktiviere den Schlie�en-Button
    }

    public void NeinGedrueckt()
    {
        // hier k�nnen Sie Code einf�gen, der ausgef�hrt wird, wenn der "Nein"-Button gedr�ckt wird
        Debug.Log("Der Nein-Button wurde gedr�ckt!");
        jaButton.SetActive(false); // deaktiviere den "Ja"-Button
        neinButton.SetActive(false); // deaktiviere den "Nein"-Button
        textField.SetActive(false); // deaktiviere das Textfeld
        image.SetActive(false); // deaktiviere das Bild
        slider.SetActive(true); // aktiviere den Slider
        closeButton.SetActive(true); // aktiviere den Schlie�en-Button
    }

    public void SchliessenGedrueckt()
{
    jaButton.SetActive(false); // deaktiviere den "Ja"-Button
    neinButton.SetActive(false); // deaktiviere den "Nein"-Button
    textField.SetActive(false); // deaktiviere das Textfeld
    image.SetActive(false); // deaktiviere das Bild
    slider.SetActive(false); // deaktiviere den Slider
    closeButton.SetActive(false); // deaktiviere den Schlie�en-Button
        kleinerButton.SetActive(false);
}
}

