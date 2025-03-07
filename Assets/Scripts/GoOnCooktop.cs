using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoOnCooktop : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        // Récupère le composant Rigidbody
        rb = GetComponent<Rigidbody>();

        // Gèle la rotation sur les axes X et Z
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnGrab()
    {
        Debug.Log("Objet grab !");
        // Ajoute ici le code que tu veux exécuter
        //Unblock();
    }

    public void Unblock(){
        rb.constraints = RigidbodyConstraints.None;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    public void Block(){
        rb.constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }

    public void SetRotationToNormal(){
        transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);
    }
}
