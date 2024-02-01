using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store_InventoryUI : InventoryUI
{
    private void Start()
    {
        InventoryRef = transform.GetComponent<Inventory>();
        UpdateInventoryUI();
    }

    public void SetPlayerChoosenStore()
    {
        Player_Data.CurrentChoosenStoreUI = this;
    }
}
