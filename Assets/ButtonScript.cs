using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject eingabefeld; // das GameObject, das das Textfeld enthält
    public GameObject kleinerButton; // das GameObject, das den kleineren Button enthält
    public GameObject jaButton; // das GameObject, das den "Ja"-Button enthält
    public GameObject neinButton; // das GameObject, das den "Nein"-Button enthält
    public GameObject textField; // das GameObject, das das Textfeld enthält
    public GameObject image; // das GameObject, das das Bild enthält
    public GameObject slider; // das GameObject, das den Slider enthält
    public GameObject closeButton; // das GameObject, das den Schließen-Button enthält

    void Start()
    {
        eingabefeld.SetActive(false); // deaktiviere das Textfeld am Anfang
        kleinerButton.SetActive(false); // deaktiviere den kleineren Button am Anfang
        jaButton.SetActive(false); // deaktiviere den "Ja"-Button am Anfang
        neinButton.SetActive(false); // deaktiviere den "Nein"-Button am Anfang
        textField.SetActive(false); // deaktiviere das Textfeld am Anfang
        image.SetActive(false); // deaktiviere das Bild am Anfang
        slider.SetActive(false); // deaktiviere den Slider am Anfang
        closeButton.SetActive(false); // deaktiviere den Schließen-Button am Anfang
    }

    public void ZeigeEingabefeld()
    {
        eingabefeld.SetActive(true); // aktiviere das Textfeld, wenn der Hauptbutton gedrückt wird
        kleinerButton.SetActive(true); // aktiviere den kleineren Button, wenn der Hauptbutton gedrückt wird
    }

    public void ZeigeButtons()
    {
        jaButton.SetActive(true); // aktiviere den "Ja"-Button, wenn der Hauptbutton gedrückt wird
        neinButton.SetActive(true); // aktiviere den "Nein"-Button, wenn der Hauptbutton gedrückt wird
        textField.SetActive(false); // deaktiviere das Textfeld, wenn der Hauptbutton gedrückt wird
        image.SetActive(false); // deaktiviere das Bild, wenn der Hauptbutton gedrückt wird
        slider.SetActive(false); // deaktiviere den Slider, wenn der Hauptbutton gedrückt wird
        closeButton.SetActive(false); // deaktiviere den Schließen-Button, wenn der Hauptbutton gedrückt wird
    }

    public void JaGedrueckt()
    {
        // hier können Sie Code einfügen, der ausgeführt wird, wenn der "Ja"-Button gedrückt wird
        Debug.Log("Der Ja-Button wurde gedrückt!");
        jaButton.SetActive(false); // deaktiviere den "Ja"-Button
        neinButton.SetActive(false); // deaktiviere den "Nein"-Button
        textField.SetActive(false); // deaktiviere das Textfeld
        image.SetActive(true); // aktiviere das Bild
        slider.SetActive(false); // deaktiviere den Slider
        closeButton.SetActive(false); // deaktiviere den Schließen-Button
    }

    public void NeinGedrueckt()
    {
        // hier können Sie Code einfügen, der ausgeführt wird, wenn der "Nein"-Button gedrückt wird
        Debug.Log("Der Nein-Button wurde gedrückt!");
        jaButton.SetActive(false); // deaktiviere den "Ja"-Button
        neinButton.SetActive(false); // deaktiviere den "Nein"-Button
        textField.SetActive(false); // deaktiviere das Textfeld
        image.SetActive(false); // deaktiviere das Bild
        slider.SetActive(true); // aktiviere den Slider
        closeButton.SetActive(true); // aktiviere den Schließen-Button
    }

    public void SchliessenGedrueckt()
{
    jaButton.SetActive(false); // deaktiviere den "Ja"-Button
    neinButton.SetActive(false); // deaktiviere den "Nein"-Button
    textField.SetActive(false); // deaktiviere das Textfeld
    image.SetActive(false); // deaktiviere das Bild
    slider.SetActive(false); // deaktiviere den Slider
    closeButton.SetActive(false); // deaktiviere den Schließen-Button
        kleinerButton.SetActive(false);
}
}

