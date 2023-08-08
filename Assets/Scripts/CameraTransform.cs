using UnityEngine;

public class CameraTransform : MonoBehaviour
{
    private GameObject _player;

    private Vector3 _offset;

    // Start is called before the first frame update
    private void Start()
    {
        this._player = GameObject.Find("malebot");
        _offset = transform.position - _player.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = _player.transform.position + _offset;
    }
}