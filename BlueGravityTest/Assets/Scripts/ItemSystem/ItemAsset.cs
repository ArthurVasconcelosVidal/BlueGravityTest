using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class ItemAsset : ScriptableObject{

    public enum ItemCategory{ clothes, weapon, misc, usable, none }
    [SerializeField] Sprite sprite;
    [SerializeField] ItemCategory category;
    [SerializeField] string name;
    [SerializeField] int price;
    [SerializeField] string id;
    public Sprite Sprite { get => sprite; }
    public ItemCategory Category { get => category; }
    public string Name { get => name; }
    public int Price { get => price; }
    public string ID { get => id; }
}
