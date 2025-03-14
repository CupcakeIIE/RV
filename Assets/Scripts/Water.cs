using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private GameObject _water;
    [SerializeField] private GameObject _waterInPot;
    private bool _isFull;

    private void Start()
    {
        _isFull = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == _water && !_isFull)
        {
            GameObject fullWater = Instantiate(_waterInPot, transform);
            fullWater.transform.SetLocalPositionAndRotation(new Vector3(0f, 0.35f, 0f), Quaternion.identity);
            _isFull = true;
        }
    }
}
