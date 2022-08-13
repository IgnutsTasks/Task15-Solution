using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    [SerializeField] private Item[] items;
    [SerializeField] private ItemUI itemUIPrefab;
    [SerializeField] private Transform layout;
    [SerializeField] private ItemInfoWindow itemInfoWindow;

    private void Start() => Initialize();
    private void Initialize()
    {
        foreach (var item in items)
        {
            ItemUI newItem = Instantiate(itemUIPrefab, layout);
            newItem.icon.sprite = item.icon;
            newItem.button.onClick.AddListener(delegate
            {
                OpenItemInfo(item);
            });
        }
    }

    private void OpenItemInfo(Item item)
    {
        itemInfoWindow.icon.sprite = item.icon;
        itemInfoWindow.describeText.text = item.describe;
        itemInfoWindow.priceText.text = item.price.ToString();
        
        itemInfoWindow.gameObject.SetActive(true);
    }
}
