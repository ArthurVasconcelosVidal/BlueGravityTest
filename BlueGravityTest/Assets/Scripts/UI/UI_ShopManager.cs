using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class UI_ShopManager : MonoBehaviour{

    [SerializeField] UI_ItemPanelManager[] ui_ItemPanelManagers;
    [SerializeField] ItemAsset baseItem;
    [SerializeField] Button nextButton,previousButton;

    ItemAsset[] items;
    int itemIndex = 0;
    int missingItems;
    const int MINIMUM_QUANTITY = 4;

    public void OrganizeStore(ItemAsset[] items){
        this.items = items;
        missingItems = items.Length % MINIMUM_QUANTITY;
        itemIndex = 0;
        if (missingItems != 0)
            AdjustingItemArray();
        DisplayItems();
    }

    void AdjustingItemArray(){
        var newLength = missingItems + items.Length;
        ItemAsset[] newArray = new ItemAsset[newLength];
        items.CopyTo(newArray,0);
        items =  newArray;
    }

    void DisplayItems(){
        foreach (var itemPanel in ui_ItemPanelManagers){
            if(items[itemIndex])
                itemPanel.SetValues(items[itemIndex]);
            else
                itemPanel.SetValues(baseItem);
            itemIndex++;
        }
        VerifyNextState();
    }

    void VerifyNextState(){
        if(items.Length - (itemIndex + 1) > 0)
            nextButton.interactable = true;
        else
            nextButton.interactable = false;

        if(itemIndex - MINIMUM_QUANTITY <= 0)
            previousButton.interactable = false;
        else
            previousButton.interactable = true;
    }

    public void ButtonNext(){
        DisplayItems();
    }

    public void ButtonPrevious(){
        itemIndex -= MINIMUM_QUANTITY * 2;
        DisplayItems();
    }

    public void ButtonBuy(){
        print("Todo");
        //Buy selected Item;
    }
}
