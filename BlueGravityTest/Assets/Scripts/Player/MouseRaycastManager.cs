using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class MouseRaycastManager : MonoBehaviour{
    
    [SerializeField] LayerMask raycastLayer;
    //Serialized for debug
    [Header("Debug")]
    [SerializeField] Vector2 lastMousePosition = Vector2.zero;
    [SerializeField] GameObject hitObj;
    
    public GameObject HitObj { get => hitObj; }

    void Update(){
        RaycastBehavior();
    }

    void RaycastBehavior(){
        if(lastMousePosition != PlayerManager.instance.PlayerInput.MousePosition){
            lastMousePosition = PlayerManager.instance.PlayerInput.MousePosition;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(lastMousePosition), Vector2.zero, math.INFINITY, raycastLayer);
            
            if(hit.collider != null) hitObj = hit.collider.gameObject;
            else hitObj = null;
        }
    }
}
