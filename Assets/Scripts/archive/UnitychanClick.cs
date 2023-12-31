using UnityEngine;


public class UnitychanClick : MonoBehaviour
{
    private Transition _transition;
    private const string Avatar = "unitychan";

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
}
