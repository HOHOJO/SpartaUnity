using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Button button;
    public Image icon;
    public TextMeshProUGUI quatityText;
    public TextMeshProUGUI Name;
    private ItemSlot curSlot;
    private Outline outline;
    public ItemData itemData;
    public GameObject equip;

    public int index;
    public bool equipped;

    private void Awake()
    {
        outline = GetComponent<Outline>();
        equipped = false;
    }

    private void Update()
    {
        if(equipped)
        {
            equip.SetActive(true);
        }
        else
        {
            equip.SetActive(false);
        }    
    }

    private void OnEnable()
    {
        outline.enabled = equipped;
    }

    public void OnButtonClick()
    {
        Name.text = itemData.displayName;
        quatityText.text = itemData.description;
        Inventory.instance.SelectItem(index);
    }
}