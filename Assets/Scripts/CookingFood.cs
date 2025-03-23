using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CookingFood : MonoBehaviour
{
    private int counter = 0;
    private bool counting = false;

    [SerializeField] GameObject plaque1;
    [SerializeField] GameObject plaque2;
    [SerializeField] GameObject plaque3;

    public ParticleSystem fumee;
    [SerializeField] private bool _isWater;
    [SerializeField] private GameObject _potatoe;



    private Rigidbody rb = null;


    // Start is called before the first frame update
    void Start()
    {
        
        // Récupère le composant Rigidbody
        if (TryGetComponent<Rigidbody>(out Rigidbody rbTemp)) {
            rb = rbTemp;
        }

        if (rb !=null){
            
        // Gèle la rotation sur les axes X et Z
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }

        Debug.Log("start");
        plaque1 = GameObject.Find("Plate");
        plaque2 = GameObject.Find("Plate (1)");
        plaque3 = GameObject.Find("Plate (2)");
    }

    // Update is called once per frame
    void Update()
    {   if (_isWater){
        counting = true;
    }
        if ((plaque1.GetComponent<Cooktop>().panOnFire && plaque1.GetComponent<Cooktop>().isOn) || (plaque2.GetComponent<Cooktop>().panOnFire && plaque2.GetComponent<Cooktop>().isOn) || (plaque3.GetComponent<Cooktop>().panOnFire && plaque3.GetComponent<Cooktop>().isOn))
        {
            if (counting)
            {
                counter += 1;
            }

            if (counter >= 500 && !_isWater)
            {
                this.transform.GetComponent<Renderer>().material.color = new Color(0.64f, 0.164f, 0.164f, 1.0f);;
            }

            if (counter >= 1000 && !_isWater)
            {
                counter = 0;
                this.transform.GetComponent<Renderer>().material.color = Color.black;

                fumee.Play();
                fumee.transform.position = this.transform.position;
            }
        }
        else if ((plaque1.GetComponent<Cooktop>().potOnFire && plaque1.GetComponent<Cooktop>().isOn) || (plaque2.GetComponent<Cooktop>().potOnFire && plaque2.GetComponent<Cooktop>().isOn) || (plaque3.GetComponent<Cooktop>().potOnFire && plaque3.GetComponent<Cooktop>().isOn))
        {   
            if (counting)
            {
            Debug.Log("tamerelapute");
                counter += 1;
            }

            if (counter >= 1000 && _isWater)
            {
                Transform cylinder = transform.Find("Cylinder");
                cylinder.gameObject.TryGetComponent<PotatoeInWater>(out PotatoeInWater potatoes);
                GameObject potatoe = Instantiate(_potatoe);
                potatoe.transform.position = transform.position + Vector3.up;
                Destroy(gameObject);
                potatoes.ResetPotatoes();
                Water.IsFull = false;
            }
        }
        else
        {
            if (fumee != null){
                fumee.Pause();
                fumee.Clear();
            }
        }
    }

    
    void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet en collision a le tag "Pan"
        if (other.CompareTag("pan") || other.CompareTag("pot"))
        {
            this.transform.position = other.transform.position;
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.05f, this.transform.position.z);
            this.transform.rotation = other.transform.rotation;
            if (rb !=null){
                rb.constraints = RigidbodyConstraints.FreezeRotationX |RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            }
            Debug.Log("trrrrrriiiiiigggggggggggggggggeeeeeerrrrrr");
            counting = true;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        // Vérifie si l'objet en collision a le tag "Pan"
        if (other.CompareTag("pan") || other.CompareTag("pot"))
        {
            if (rb !=null){
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ; 
            }
            counting = false;
        }
    }
}
