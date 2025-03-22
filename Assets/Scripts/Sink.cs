using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour
{
    private bool _isOpened;
    [SerializeField] private GameObject _water;
    // Start is called before the first frame update
    void Start()
    {
        _isOpened = false;
    }

    public void Open()
    {
        _isOpened = !_isOpened;
        _water.SetActive(_isOpened);
    }
}
