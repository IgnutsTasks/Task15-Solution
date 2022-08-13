using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item1", menuName = "ScriptableObjects/ShopItem", order = 1)]
public class Item : ScriptableObject
{
    public string title = "Unknown";
    [TextArea(4, 6)]
    public string describe = "...";
    public Sprite icon;
    public int price = 0;
}
