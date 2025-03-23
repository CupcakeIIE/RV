using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    Renderer goRenderer;
    [SerializeField] Material mat1;
    [SerializeField] Material mat2;

    bool isOn = false;
    // Start is called before the first frame update

    void Start()
    {
        goRenderer = GetComponent<Renderer>();
        
    }
    public void ChangeMat(){
        if (isOn){
            goRenderer.material = mat2;
            isOn = false;
        } else {
            isOn = true;
            goRenderer.material = mat1;
        }
    }
}
