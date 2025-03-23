using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoeInWater : MonoBehaviour
{
    private bool _potatoesCooked;
    // Start is called before the first frame update
    void Start()
    {
        _potatoesCooked = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out CutFood cf) && !_potatoesCooked)
        {
            Destroy(cf.gameObject);
            _potatoesCooked = true;
        }
    }

    public void ResetPotatoes()
    {
        _potatoesCooked = false;
    }
}
