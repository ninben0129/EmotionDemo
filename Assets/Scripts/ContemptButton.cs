using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContemptButton : MonoBehaviour
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
    public void Onclick()
    {
        transition = GameObject.Find("malebot").GetComponent<Transition>();
        transition.Contempt();
    }
}
