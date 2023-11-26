using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseRaycastManager : MonoBehaviour{

    [SerializeField] LayerMask raycastLayer;
    [SerializeField] MouseCursorController mouseCursor;
    
    //Serialized for debug
    [Header("Debug")]
    [SerializeField] Vector2 lastMousePosition = Vector2.zero;
    [SerializeField] GameObject hitObj;
    
    public GameObject HitObj { 
        get => hitObj; 
        set {
            if(value != hitObj){
                hitObj = value;
                SetMouseCursor();
            }
        }
    }

    void Update(){
        RaycastBehavior();
    }

    void RaycastBehavior(){
        if(lastMousePosition != PlayerManager.instance.PlayerInput.MousePosition){
            lastMousePosition = PlayerManager.instance.PlayerInput.MousePosition;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(lastMousePosition), Vector2.zero, math.INFINITY, raycastLayer);
            
            if(hit.collider != null)
                HitObj = hit.collider.gameObject;
            else HitObj = null;
        }
    }
    
    public void SetMouseCursor(){
        if(hitObj != null && PlayerManager.instance.CanInteract){
            mouseCursor.State = MouseCursorController.MouseState.MOUSE_HIGHLIGHTED;
        }
        else if(hitObj != null && !PlayerManager.instance.CanInteract)
            mouseCursor.State = MouseCursorController.MouseState.MOUSE_SELECTED;
        else
            mouseCursor.State = MouseCursorController.MouseState.MOUSE_BASE;
    }   
}
