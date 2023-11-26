using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour{

    void Update() {
        if(PlayerManager.instance.PlayerInput.InputAxis != Vector2.zero)
            MoveCamera(PlayerManager.instance.PlayerRigidbody.transform.position);
    }

    void MoveCamera(Vector2 playerPosition){
        
        Vector3 newPos = new Vector3(
        PlayerManager.instance.PlayerRigidbody.transform.position.x,
        PlayerManager.instance.PlayerRigidbody.transform.position.y,
        Camera.main.transform.position.z);

        Camera.main.transform.position = newPos;
    }
}
