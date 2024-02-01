using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_InventoryUI : InventoryUI
{
    private void Start()
    {
        //InventoryRef = Player_Data.Player_Inventory;
        Player_Data.CurrentInventoryUI = this;
        UpdateInventoryUI();
    }
}
