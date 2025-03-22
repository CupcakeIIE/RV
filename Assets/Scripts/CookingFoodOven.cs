using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingFoodOven : MonoBehaviour
{
    Renderer goRenderer;
    [SerializeField] Material material;
    // Start is called before the first frame update
    void Start()
    {
        goRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cook(float dt){
        
        goRenderer.material = material;
    }
}
