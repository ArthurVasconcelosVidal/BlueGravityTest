using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractiveBehavior : MonoBehaviour{
    [SerializeField] string playerTag = "Player";
    PlayerInput Input { get => PlayerManager.instance.PlayerInput;  } 

    void Behavior(object sender, InputAction.CallbackContext context){
        InteractionBehavior();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag(playerTag)){
            Input.OnMouseLeftClick += Behavior;
            PlayerManager.instance.CanInteract = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag(playerTag)){
            PlayerManager.instance.CanInteract = false;
            Input.OnMouseLeftClick -= Behavior;
            ExitInteraction();
        }
            
    }

    protected bool VerifyMoyseRaycast(){
        GameObject obj = PlayerManager.instance.MouseRaycastManager.HitObj;

        if ( obj != null && obj == this.gameObject) 
            return true;
        
        return false;
    }

    protected virtual void InteractionBehavior() {}
    protected virtual void ExitInteraction() {}
}
