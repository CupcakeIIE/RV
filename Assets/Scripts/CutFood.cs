using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutFood : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet en collision a le tag "Pan"
        if (other.CompareTag("couteau"))
        {
            this.transform.Find("avant").gameObject.SetActive(false);
            this.transform.Find("apres").gameObject.SetActive(true);
            PlaySound();
        }
    }

    void PlaySound(){
        audioSource.Play();
    }
}
