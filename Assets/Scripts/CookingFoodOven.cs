using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingFoodOven : MonoBehaviour
{
    Renderer goRenderer;
    float timer = 0f;
    [SerializeField] Material cooked;
    [SerializeField] Material burnt;
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
        timer+=dt;
        if (timer >= 20){
            goRenderer.material = burnt;
        } else if (timer >= 10){
            goRenderer.material = cooked;
        } 
    }
}
