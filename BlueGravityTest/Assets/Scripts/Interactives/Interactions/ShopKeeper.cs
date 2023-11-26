using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : InteractiveBehavior{

    [SerializeField] Canvas uiShopCanvas;
    [SerializeField] ItemAsset[] itemAssets;

    protected override void InteractionBehavior(){
        if(VerifyMoyseRaycast()){
            print("OLÁ AMIGOS COMO ESTÃO ?");
            uiShopCanvas.gameObject.SetActive(true);
            uiShopCanvas.GetComponent<UI_ShopManager>().OrganizeStore(itemAssets);
        }
    }

    protected override void ExitInteraction(){
        uiShopCanvas.gameObject.SetActive(false);
    }
}
