using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeAttachPoint : MonoBehaviour
{
    [SerializeField] Transform leftHand;
    [SerializeField] Transform rightHand;

    [SerializeField] GameObject firstAttachPoint;
    [SerializeField] GameObject secondAttachPoint;
    
    public void GrabWeapon(SelectEnterEventArgs grabData)
        {
            var isLeftHand = (grabData.interactorObject.interactionLayers & (1 << 1)) == 0;

            /*if (isLeftHand){
                attachPoint.transform.position = leftHand.position;
                attachPoint.transform.rotation = leftHand.rotation;
            } else {
                attachPoint.transform.position = rightHand.position;
                attachPoint.transform.rotation = rightHand.rotation;
            }*/
        }
}
