using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    private Transition _transition;
    private const string Avatar = "malebot";
    TMP_InputField _inputField;
    public Text text;

    public void DisgustClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Disgust();
    }

    public void FearClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Fear();
    }

    public void GratitudeClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Gratitude();
    }

    public void GuiltClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Guilt();
    }

    public void JealousyClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Jealousy();
    }

    public void JoyClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Joy();
    }

    public void PrideClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Pride();
    }

    public void SadnessClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Sadness();
    }

    public void ShameClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Shame();
    }

    public void SurpriseClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Surprise();
    }

    public void NeutralClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Neutral();
    }

    public void HighClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.High();
    }

    public void MiddleClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Middle();
    }

    public void LowClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Low();
    }

    public void AngerClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Anger();
    }

    public void ContemptClick()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Contempt();
    }

    public void Scenario1Click()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Scenario1();
    }

    public void Scenario2Click()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Scenario2();
    }

    public void Scenario3Click()
    {
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.Scenario3();
    }

    public void PersonSet()
    {
        _inputField = GameObject.Find("inputnum").GetComponent<TMP_InputField>();
        int person;
        int.TryParse(_inputField.text, out person);
        _transition = GameObject.Find(Avatar).GetComponent<Transition>();
        _transition.SetPerson(person);
    }
}