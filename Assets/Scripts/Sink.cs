using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour
{
    private bool _isOpened;
    private AudioSource audioSource;
    [SerializeField] private GameObject _water;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  
        _isOpened = false;
    }

    public void Open()
    {
        _isOpened = !_isOpened;
        /*if (_isOpened){
            audioSource.Play();
        } else {
            audioSource.Stop();
        }*/
        _water.SetActive(_isOpened);
    }
}
