using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class ItemAsset : ScriptableObject{
    [SerializeField] Sprite sprite;
    [SerializeField] string name;
    [SerializeField] int price;

    public Sprite Sprite { get => sprite; }
    public string Name { get => name; }
    public int Price { get => price; }
}
