using System;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    private Animator _animator;
    private Vector3 _initposition;

    private Vector3 _initrotate;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        var transform1 = transform;
        _initposition = transform1.position;
        _initrotate = transform1.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo stateInfo = _animator.GetCurrentAnimatorStateInfo(0);
        if (Math.Abs(stateInfo.normalizedTime - 1.0) < 0.01)
        {
            var transform1 = transform;
            transform1.position = _initposition;
            transform1.localEulerAngles = _initrotate;
        }
        /*
         if (Math.Abs(stateInfo.normalizedTime) < 0.01)
        {
            var transform1 = transform;
            transform1.position = _initposition;
            transform1.localEulerAngles = _initrotate;
        }
        */
    }

    void Reset()
    {
        var transform1 = transform;
        transform1.position = _initposition;
        transform1.localEulerAngles = _initrotate;
    }
}
