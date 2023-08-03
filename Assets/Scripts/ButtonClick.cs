using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    private Transition transition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Disgustclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Disgust();
    }
    public void Fearclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Fear();
    }
    public void Gratitudetclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Gratitude();
    }
    public void Guiltclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Guilt();
    }
    public void Jealousyclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Jealousy();
    }
    public void Joytclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Joy();
    }
    public void Prideclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Pride();
    }
    public void Sadnessclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Sadness();
    }
    public void Shametclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Shame();
    }
    public void Surpriseclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Surprise();
    }
    public void Neutralclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Neutral();
    }
    public void Highclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.High();
    }
    public void Middleclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Middle();
    }
    public void Lowclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Low();
    }
    public void Angerclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Anger();
    }
    public void Contemptclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Contempt();
    }
}
