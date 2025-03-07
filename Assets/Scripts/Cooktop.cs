using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooktop : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer goRenderer;
    [SerializeField] Transform cookingPos;
    [SerializeField] Material onMaterial;
    [SerializeField] Material offMaterial;
    private bool isOn = false;
    void Start()
    {
        goRenderer = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet en collision a le tag "Pan"
        if (other.CompareTag("pan"))
        {
            // Affiche un message dans la console
            other.transform.position = cookingPos.position;
            other.transform.rotation = cookingPos.rotation;

            GoOnCooktop cookingScript = other.GetComponent<GoOnCooktop>();
            if (cookingScript != null)
            {
                cookingScript.Block(); // Appelle la fonction Block
            }
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        // Vérifie si l'objet en collision a le tag "Pan"
        if (other.CompareTag("pan"))
        {
            // Affiche un message dans la console

            GoOnCooktop cookingScript = other.GetComponent<GoOnCooktop>();
            if (cookingScript != null)
            {
                cookingScript.Unblock(); // Appelle la fonction Block
            }
        }
    }

    public void OnButtonClicked(){
        if (isOn){
            goRenderer.material = offMaterial;
            isOn = false;
        } else {
            goRenderer.material = onMaterial;
            isOn = true;
        }
    }
}
