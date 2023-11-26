using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour{
    public static PlayerManager instance;

    [SerializeField] PlayerInput playerInput;
    [SerializeField] MovementBehavior movementBehavior;
    [SerializeField] AnimationManager animationManager;
    [SerializeField] Rigidbody2D playerRigidbody;
    [SerializeField] GameObject spriteObj;
    [SerializeField] MouseRaycastManager mouseRaycastManager;
    [SerializeField] PlayerWallet wallet;
    [SerializeField] ClothesManager clothesManager;

    ItemAsset receivedItem;

    public PlayerInput PlayerInput { get => playerInput; }
    public MovementBehavior MovementBehavior { get => movementBehavior; }
    public AnimationManager AnimationManager { get => animationManager; }
    public Rigidbody2D PlayerRigidbody { get => playerRigidbody; }
    public GameObject SpriteObj { get => spriteObj; }
    public MouseRaycastManager MouseRaycastManager { get => mouseRaycastManager; }
    public PlayerWallet Wallet { get => wallet; }
    public ClothesManager ClothesManager { get => clothesManager; }
    public ItemAsset ReceivedItem {
        get => receivedItem;

        set {
            receivedItem = value;
            switch (receivedItem.Category){
                case ItemAsset.ItemCategory.clothes:
                    clothesManager.ChangeClothes(receivedItem);
                    break;
                case ItemAsset.ItemCategory.misc:
                    break;
                case ItemAsset.ItemCategory.usable:
                    break;
                case ItemAsset.ItemCategory.weapon:
                    break;
                default:
                    break;
            }
        }
    }

    void Awake() {
        SingletonPattern();
    }

    void SingletonPattern(){
        if(instance == null) instance = this;
        else Destroy(instance);
    }
}
