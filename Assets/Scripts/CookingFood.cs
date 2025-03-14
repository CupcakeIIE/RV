using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingFood : MonoBehaviour
{
    private int counter = 0;
    private bool counting = false;

    private GameObject food;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counting)
        {
            counter += 1;
        }

        if (counter >= 1000)
        {
            counter = 0;
            food.transform.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    
    void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet en collision a le tag "Pan"
        if (other.CompareTag("food"))
        {
            counting = true;
            food = other.gameObject;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        // Vérifie si l'objet en collision a le tag "Pan"
        if (other.CompareTag("food"))
        {
            counting = false;
        }
    }
}
