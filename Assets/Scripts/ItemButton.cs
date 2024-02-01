using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public Item ItemRef;
    public TMP_Text ItemNameUI;
    public TMP_Text ItemPriceUI;
    public Image ItemIconUI;

    public void SetButtonData(Item Item)
    {
        ItemRef = Item;
        ItemIconUI.sprite = ItemRef.Icon;
        ItemNameUI.SetText(ItemRef.Name);
        ItemPriceUI.SetText("" + ItemRef.Price);
    }

    public void Sell()
    {
        Player_Data.Sell(ItemRef);
    }

    public void Buy()
    {
        Player_Data.Buy(ItemRef);
    }
}
