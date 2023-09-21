using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ItemSlot
{
    public ItemData item;
    public int quantity;
}

public class Inventory : MonoBehaviour
{
    public ItemSlotUI[] uiSlots;
    public ItemSlot[] slots;

    public GameObject inventoryWindow;

    [Header("Selected Item")]
    private ItemSlot selectedItem;
    private int selectedItemIndex;
    public GameObject infoPop;
    public GameObject unEquipButton;
    public GameObject equipButton;
    public GameObject unEquipButton2;
    public GameObject equipButton2;
    private int curEquipIndex;
    private int selectIndex;

    public static Inventory instance;
    void Awake()
    {
        instance = this;
    }
    private void Start()
    {

    }


    public bool IsOpen()
    {
        return true;
    }

    private void Update()
    {

    }


    void UpdateUI()
    {

    }

    public void OnEquipButton()
    {

    }

    void UnEquip(int index)
    {

    }

    public void OnUnEquipButton()
    {

    }

    internal void SelectItem(int index)
    {
        selectIndex = index;
        if (uiSlots[selectIndex].equipped)
        {
            //unEquipButton.SetActive(true);
            //equipButton.SetActive(false);
            unEquipButton2.SetActive(true);
            equipButton2.SetActive(false);
        }
        else
        {
            //unEquipButton.SetActive(false);
            //equipButton.SetActive(true);
            unEquipButton2.SetActive(false);
            equipButton2.SetActive(true);
        }

    }

    public void Equip()
    {
        if (uiSlots[curEquipIndex].equipped)
        {
            UnEquip();
        }
        curEquipIndex = selectIndex;
        uiSlots[curEquipIndex].equipped = true;
        //infoPop.SetActive(false);
        equipButton2.SetActive(false);
        unEquipButton2.SetActive(false);
    }

    public void UnEquip()
    {
        uiSlots[curEquipIndex].equipped = false;
        //infoPop.SetActive(false);
        equipButton2.SetActive(false);
        unEquipButton2.SetActive(false);
    }
}
