using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour{
    public static PlayerManager instance;

    [SerializeField] PlayerInput playerInput;
    [SerializeField] MovementBehavior movementBehavior;
    [SerializeField] Rigidbody2D playerRigidbody;
    [SerializeField] GameObject spriteObj;

    public PlayerInput PlayerInput { get { return playerInput; } }
    public MovementBehavior MovementBehavior { get { return movementBehavior; } }
    public Rigidbody2D PlayerRigidbody { get { return playerRigidbody; } }
    public GameObject SpriteObj { get { return spriteObj; } }

    void Awake() {
        SingletonPattern();
    }

    void SingletonPattern(){
        if(instance == null) instance = this;
        else Destroy(instance);
    }
}
