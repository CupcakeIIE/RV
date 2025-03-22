using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private GameObject _waterInPot;
    private bool _isFull;

    void Start()
    {
        _isFull = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Sink sink) && !_isFull)
        {
            GameObject fullWater = Instantiate(_waterInPot, transform);
            fullWater.transform.SetLocalPositionAndRotation(new Vector3(0f, 0.08f, 0f), Quaternion.identity);
            _isFull = true;
        }
    }
}
