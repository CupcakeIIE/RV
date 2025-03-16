using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingFood : MonoBehaviour
{
    private int counter = 0;
    private bool counting = false;

    public GameObject plaque1;
    public GameObject plaque2;
    public GameObject plaque3;

    public ParticleSystem fumee;

    // Start is called before the first frame update
    void Start()
    {
        fumee.Stop(true, ParticleSystemStopBehavior.StopEmitting);
    }

    // Update is called once per frame
    void Update()
    {
        if (plaque1.GetComponent<Cooktop>().panOnFire || plaque2.GetComponent<Cooktop>().panOnFire || plaque3.GetComponent<Cooktop>().panOnFire)
        {
            if (counting)
            {
                counter += 1;
            }

            if (counter >= 1000)
            {
                counter = 0;
                this.transform.GetComponent<Renderer>().material.color = Color.black;
                //fumee.SetActive(true);
                fumee.transform.position = this.transform.position;
                fumee.Play();
            }
        }
    }

    
    void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet en collision a le tag "Pan"
        if (other.CompareTag("pan"))
        {
            this.transform.position = other.transform.position;
            this.transform.rotation = other.transform.rotation;
            counting = true;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        // Vérifie si l'objet en collision a le tag "Pan"
        if (other.CompareTag("pan"))
        {
            counting = false;
        }
    }
}
