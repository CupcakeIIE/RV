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

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out CutFood cf) && _potatoesCooked < _maxPotatoes)
        {
            Destroy(cf.gameObject);
            _potatoesCooked++;
        }
    }

    public int GetPotatoes()
    {
        return _potatoesCooked;
    }
}
