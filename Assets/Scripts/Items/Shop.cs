using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ItemSlotShop
{
    public ItemData item;
    public int quantity;
}

public class Shop : MonoBehaviour
{
    public ItemSlotUI[] uiSlots;
    public ItemSlotShop[] slots;

    public GameObject inventoryWindow;

    [Header("Selected Item")]
    private ItemSlot selectedItem;
    private int selectedItemIndex;
    public GameObject BuyPop;
    public GameObject BuyButton;
    private int curEquipIndex;
    private int selectIndex;

    public static Shop instance;
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    internal void SelectItem(int index)
    {
        selectIndex = index;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {
        curEquipIndex = selectIndex;

    }
}
