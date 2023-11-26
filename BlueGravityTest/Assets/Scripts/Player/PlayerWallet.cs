using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallet : MonoBehaviour{
    [SerializeField] int gold = 50000;

    public int Gold { get => gold; }

    public void UpdateGold(int quantity){
        gold += quantity;
    }

    public bool CanSpend(int quantity){
        if(quantity <= gold)
            return true;
        return false;
    }
}
