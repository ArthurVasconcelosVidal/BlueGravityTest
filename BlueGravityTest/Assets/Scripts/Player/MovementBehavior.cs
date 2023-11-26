using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
public class MovementBehavior : MonoBehaviour{
    [SerializeField] float moveSpeed;


    void Start() {
        PlayerManager.instance.PlayerInput.OnInputAxisChange += IsMoving;
    }

    void Update(){
        Vector2 inputAxis = PlayerManager.instance.PlayerInput.InputAxis;
        if(inputAxis != Vector2.zero){
            Movement(inputAxis);
            //Rotation(inputAxis);
            PlayerManager.instance.AnimationManager.Axis = inputAxis;
        }
    }

    void Movement(Vector3 direction){
        PlayerManager.instance.PlayerRigidbody.transform.position += direction * moveSpeed * Time.deltaTime;
    }

    void Rotation(Vector3 direction){
        Quaternion newRot = Quaternion.LookRotation(PlayerManager.instance.PlayerRigidbody.transform.forward,direction);
        PlayerManager.instance.PlayerRigidbody.transform.rotation = newRot;
    }

    void IsMoving(object sender, InputAction.CallbackContext context){
        if(PlayerManager.instance.PlayerInput.InputAxis != Vector2.zero){
            //print("Moving");
            PlayerManager.instance.AnimationManager.IsMoving = true;
        }else
            //print("Stopped");
            PlayerManager.instance.AnimationManager.IsMoving = false;
    }
}
