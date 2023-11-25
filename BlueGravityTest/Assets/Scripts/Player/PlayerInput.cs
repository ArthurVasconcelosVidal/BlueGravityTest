using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerInput : MonoBehaviour{

    GameInput inputActions;

    [SerializeField] Vector2 inputAxis = Vector2.zero;
    [SerializeField] Vector2 mousePosition = Vector2.zero;
    public Vector2 InputAxis { get => inputAxis; }
    public Vector2 MousePosition { get => mousePosition; }

    public event EventHandler<InputAction.CallbackContext> OnMouseLeftClick;

    private void Awake() {
        inputActions = new GameInput();
        inputActions.Enable();
    }

    void Start(){
        InputAxisConfig();
        MouseInputConfig();
    }

    void InputAxisConfig(){
        inputActions.PlayerInput.InputAxis.performed += contextMenu => {
            inputAxis = contextMenu.ReadValue<Vector2>();
        };
        inputActions.PlayerInput.InputAxis.canceled += contextMenu => {
            inputAxis = Vector2.zero;
        };
    }

    void MouseInputConfig(){
        inputActions.PlayerInput.Click.performed += contextMenu => {
            OnMouseLeftClick?.Invoke(this,contextMenu);
        };

        inputActions.PlayerInput.MousePosition.performed += contextMenu => {
            mousePosition = contextMenu.ReadValue<Vector2>();
        };
    }
}
