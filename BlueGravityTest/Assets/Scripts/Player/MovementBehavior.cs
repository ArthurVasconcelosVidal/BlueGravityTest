using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MovementBehavior : MonoBehaviour{
    [SerializeField] float moveSpeed;

    void Update(){
        Vector2 inputAxis = PlayerManager.instance.PlayerInput.InputAxis;
        if(inputAxis != Vector2.zero){
            Movement(inputAxis);
            Rotation(inputAxis);
        }
    }

    void Movement(Vector3 direction){
        PlayerManager.instance.PlayerRigidbody.transform.position += direction * moveSpeed * Time.deltaTime;
    }

    void Rotation(Vector3 direction){
        Quaternion newRot = Quaternion.LookRotation(PlayerManager.instance.PlayerRigidbody.transform.forward,direction);
        PlayerManager.instance.PlayerRigidbody.transform.rotation = newRot;
    }
}
