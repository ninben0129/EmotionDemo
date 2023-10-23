using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
    private Animator _animator;
    private Text _eText;
    private Text _lText;
    private Text _sText;

    private static readonly int Trans = Animator.StringToHash("trans");
    private static readonly int Level = Animator.StringToHash("level");
    private static readonly int Scenario = Animator.StringToHash("scenario");

    // Start is called before the first frame update
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Neutral()
    {
        _animator.SetInteger(Trans, 0);
        _animator.SetInteger(Level, 2);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Neutral";
        this._lText = GameObject.Find("LevelText").GetComponent<Text>();
        _lText.text = "Middle";
    }

    public void Anger()
    {
        _animator.SetInteger(Trans, 1);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Anger";
    }

    public void Contempt()
    {
        _animator.SetInteger(Trans, 2);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Contempt";
    }

    public void Disgust()
    {
        _animator.SetInteger(Trans, 3);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Disgust";
    }

    public void Fear()
    {
        _animator.SetInteger(Trans, 4);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Fear";
    }

    public void Gratitude()
    {
        _animator.SetInteger(Trans, 5);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Gratitude";
    }

    public void Guilt()
    {
        _animator.SetInteger(Trans, 6);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Guilt";
    }

    public void Jealousy()
    {
        _animator.SetInteger(Trans, 7);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Jealousy";
    }

    public void Joy()
    {
        _animator.SetInteger(Trans, 8);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Joy";
    }

    public void Pride()
    {
        _animator.SetInteger(Trans, 9);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Pride";
    }

    public void Sadness()
    {
        _animator.SetInteger(Trans, 10);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Sadness";
    }

    public void Shame()
    {
        _animator.SetInteger(Trans, 11);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Shame";
    }

    public void Surprise()
    {
        _animator.SetInteger(Trans, 12);
        this._eText = GameObject.Find("EmoText").GetComponent<Text>();
        _eText.text = "Surprise";
    }

    public void High()
    {
        _animator.SetInteger(Level, 3);
        this._lText = GameObject.Find("LevelText").GetComponent<Text>();
        _lText.text = "High";
    }

    public void Middle()
    {
        _animator.SetInteger(Level, 2);
        this._lText = GameObject.Find("LevelText").GetComponent<Text>();
        _lText.text = "Middle";
    }

    public void Low()
    {
        _animator.SetInteger(Level, 1);
        this._lText = GameObject.Find("LevelText").GetComponent<Text>();
        _lText.text = "Low";
    }

    public void Scenario1()
    {
        _animator.SetInteger(Scenario, 1);
        this._sText = GameObject.Find("ScenarioText").GetComponent<Text>();
        _sText.text = "Scenario1";
    }

    public void Scenario2()
    {
        _animator.SetInteger(Scenario, 2);
        this._sText = GameObject.Find("ScenarioText").GetComponent<Text>();
        _sText.text = "Scenario2";
    }

    public void Scenario3()
    {
        _animator.SetInteger(Scenario, 3);
        this._sText = GameObject.Find("ScenarioText").GetComponent<Text>();
        _sText.text = "Scenario3";
    }
}