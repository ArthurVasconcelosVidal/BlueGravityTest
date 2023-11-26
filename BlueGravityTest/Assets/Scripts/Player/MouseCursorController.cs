using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorController : MonoBehaviour{
    public enum MouseState{ MOUSE_BASE, MOUSE_SELECTED, MOUSE_HIGHLIGHTED }
    [SerializeField] Texture2D mouseBase, mouseSelected, mouseHighlight;
    [SerializeField] MouseState mouseState = MouseState.MOUSE_BASE;
    public bool overSomething = false;
    public bool canInteract = false;

    void Start() {
        SetMouseTexture();
    }

    public MouseState State { 
        get => mouseState;
        set {
            mouseState = value;
            SetMouseTexture();
        }
    } 

    void SetMouseTexture(){
        switch (mouseState){
            case MouseState.MOUSE_BASE:
                Cursor.SetCursor(mouseBase, Vector2.zero,  CursorMode.Auto);
                break;
            case MouseState.MOUSE_HIGHLIGHTED:
                Cursor.SetCursor(mouseHighlight, Vector2.zero,  CursorMode.Auto);
                break;
            case MouseState.MOUSE_SELECTED:
                Cursor.SetCursor(mouseSelected, Vector2.zero,  CursorMode.Auto);
                break;
            default:
                break;
        }
    }
}
