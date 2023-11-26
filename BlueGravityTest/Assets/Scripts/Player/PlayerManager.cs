using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour{
    public static PlayerManager instance;

    [SerializeField] PlayerInput playerInput;
    [SerializeField] MovementBehavior movementBehavior;
    [SerializeField] Rigidbody2D playerRigidbody;
    [SerializeField] GameObject spriteObj;
    [SerializeField] MouseRaycastManager mouseRaycastManager;
    [SerializeField] PlayerWallet wallet;

    public PlayerInput PlayerInput { get => playerInput; }
    public MovementBehavior MovementBehavior { get => movementBehavior; }
    public Rigidbody2D PlayerRigidbody { get => playerRigidbody; }
    public GameObject SpriteObj { get => spriteObj; }
    public MouseRaycastManager MouseRaycastManager { get => mouseRaycastManager; }
    public PlayerWallet Wallet { get => wallet; }

    void Awake() {
        SingletonPattern();
    }

    void SingletonPattern(){
        if(instance == null) instance = this;
        else Destroy(instance);
    }
}
