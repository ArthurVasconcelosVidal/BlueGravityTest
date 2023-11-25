using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : InteractiveBehavior{
    [SerializeField] GameObject doorCollider;
    protected override void InteractionBehavior(){
        if(VerifyMoyseRaycast())
            doorCollider.SetActive(!doorCollider.active); 
    }
}
