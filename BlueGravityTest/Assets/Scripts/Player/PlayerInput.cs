using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour{

    GameInput inputActions;

    [SerializeField] Vector2 inputAxis = Vector2.zero;

    public Vector2 InputAxis { get { return inputAxis; } }

    private void Awake() {
        inputActions = new GameInput();
        inputActions.Enable();
    }

    // Start is called before the first frame update
    void Start(){
        InputAxisConfig();
    }

    void InputAxisConfig(){
        inputActions.PlayerInput.InputAxis.performed += contextMenu => {
            inputAxis = contextMenu.ReadValue<Vector2>();
        };
        inputActions.PlayerInput.InputAxis.canceled += contextMenu => {
            inputAxis = Vector2.zero;
        };
    }
}
