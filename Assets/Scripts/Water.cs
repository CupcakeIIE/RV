using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private GameObject _waterInPot;
    public static bool IsFull;

    void Start()
    {
        IsFull = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Sink sink) && !IsFull)
        {
            GameObject fullWater = Instantiate(_waterInPot, transform);
            fullWater.transform.SetLocalPositionAndRotation(new Vector3(0f, 0.08f, 0f), Quaternion.identity);
            IsFull = true;
        }
    }
}
