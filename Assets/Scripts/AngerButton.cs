using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerButton : MonoBehaviour
{
    private Transition transition;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Onclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Anger();
    }
}
