using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvenOn : MonoBehaviour
{
    private bool isOn = false;
    private AudioSource audioSource;
    private List<CookingFoodOven> foodInOven = new List<CookingFoodOven>();
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  
        audioSource.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn){
            foreach (CookingFoodOven food in foodInOven){
                food.Cook(0f);
            }
        }
    }

    public void OnButtonClicked(){
        isOn = !isOn;
        if (isOn){
            audioSource.Play();
        } else {
            audioSource.Stop();
        }
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.TryGetComponent<CookingFoodOven>(out CookingFoodOven cook)){
            foodInOven.Add(cook);
        }
    }

    void OnTriggerExit(Collider other){
        if (other.gameObject.TryGetComponent<CookingFoodOven>(out CookingFoodOven cook)){
            foodInOven.Remove(cook);
        }
    }

}
