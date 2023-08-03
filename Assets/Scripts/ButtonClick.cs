using UnityEngine;


public class ButtonClick : MonoBehaviour
{
    private Transition _transition;
    
    public void Disgustclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Disgust();
    }
    public void Fearclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Fear();
    }
    public void Gratitudetclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Gratitude();
    }
    public void Guiltclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Guilt();
    }
    public void Jealousyclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Jealousy();
    }
    public void Joytclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Joy();
    }
    public void Prideclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Pride();
    }
    public void Sadnessclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Sadness();
    }
    public void Shametclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Shame();
    }
    public void Surpriseclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Surprise();
    }
    public void Neutralclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Neutral();
    }
    public void Highclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.High();
    }
    public void Middleclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Middle();
    }
    public void Lowclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Low();
    }
    public void Angerclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Anger();
    }
    public void Contemptclick()
    {
        _transition = GameObject.Find("malebot").GetComponent<Transition>();
        _transition.Contempt();
    }
}
