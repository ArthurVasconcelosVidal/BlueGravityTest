using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : InteractiveBehavior{
    [SerializeField] GameObject doorCollider;
    [SerializeField] GameObject openDoor;
    [SerializeField] GameObject closedDoor;

    bool closed = true; 
    protected override void InteractionBehavior(){
        if(VerifyMoyseRaycast()){
            doorCollider.SetActive(!doorCollider.active);
            openDoor.SetActive(!openDoor.active);
            closedDoor.SetActive(!closedDoor.active);
        }
    }
}
