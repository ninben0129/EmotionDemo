using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
    Animator animator;
    private Text EText;
    private Text LText;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Neutral()
    {
        animator.SetInteger("trans", 0);
        animator.SetInteger("level", 2);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Neutral";
        this.LText = GameObject.Find("LevelText").GetComponent<Text>();
        LText.text = "Middle";
    }
    public void Anger()
    {
        animator.SetInteger("trans", 1);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Anger";
    }
    public void Contempt()
    {
        animator.SetInteger("trans", 2);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Contempt";
    }
    public void Disgust()
    {
        animator.SetInteger("trans", 3);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Disgust";
    }
    public void Fear()
    {
        animator.SetInteger("trans", 4);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Fear";
    }
    public void Gratitude()
    {
        animator.SetInteger("trans", 5);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Gratitude";
    }
    public void Guilt()
    {
        animator.SetInteger("trans", 6);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Guilt";
    }
    public void Jealousy()
    {
        animator.SetInteger("trans", 7);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Jealousy";
    }
    public void Joy()
    {
        animator.SetInteger("trans", 8);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Joy";
    }
    public void Pride()
    {
        animator.SetInteger("trans", 9);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Pride";
    }
    public void Sadness()
    {
        animator.SetInteger("trans", 10);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Sadness";
    }
    public void Shame()
    {
        animator.SetInteger("trans", 11);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Shame";
    }
    public void Surprise()
    {
        animator.SetInteger("trans", 12);
        this.EText = GameObject.Find("EmoText").GetComponent<Text>();
        EText.text = "Surprise";
    }
    public void High()
    {
        animator.SetInteger("level", 3);
        this.LText = GameObject.Find("LevelText").GetComponent<Text>();
        LText.text = "High";
    }
    public void Middle()
    {
        animator.SetInteger("level", 2);
        this.LText = GameObject.Find("LevelText").GetComponent<Text>();
        LText.text = "Middle";
    }
    public void Low()
    {
        animator.SetInteger("level", 1);
        this.LText = GameObject.Find("LevelText").GetComponent<Text>();
        LText.text = "Low";
    }
}
