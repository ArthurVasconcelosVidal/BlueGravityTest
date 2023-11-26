using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ItemPanelManager : MonoBehaviour{
    
    [SerializeField] ItemAsset item;
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI price;

    ItemAsset Item { get => item; }

    public void SetValues(ItemAsset item){
        this.item = item;
        image.sprite = item.Sprite;
        price.text = item.Price.ToString();
    }
}
