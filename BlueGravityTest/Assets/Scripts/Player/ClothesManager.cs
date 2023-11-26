using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesManager : MonoBehaviour{

    public void ChangeClothes(ItemAsset itemAsset){
        switch (itemAsset.ID){
            case "goldArmor":
                PlayerManager.instance.AnimationManager.PlayClothesAnimation(AnimationManager.ClothesAnimations.A0_IdleTree.ToString());
                break;
            case "diamondArmor":
                PlayerManager.instance.AnimationManager.PlayClothesAnimation(AnimationManager.ClothesAnimations.A1_IdleTree.ToString());
                break;
            default:
                break;
        }
    }

}
