using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private GameObject _water;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == _water) enabled = true;
    }
}
