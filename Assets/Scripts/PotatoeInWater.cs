using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoeInWater : MonoBehaviour
{
    private int _potatoesCooked;
    private int _maxPotatoes = 3;
    // Start is called before the first frame update
    void Start()
    {
        _potatoesCooked = 0;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("potatoes") && _potatoesCooked < _maxPotatoes)
        {
            Destroy(other.gameObject);
            _potatoesCooked++;
        }
    }

    public int GetPotatoes()
    {
        return _potatoesCooked;
    }
}
