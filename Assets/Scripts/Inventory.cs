using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> Items;
    

    public void AddToInventory(int ItemId)
    {
        foreach (Item x in GameManagerSystem.InventoryItems)
        {
            if (x.Id == ItemId)
            {
                Items.Add(x);
                break;
            }
        }
    }

    public void RemoveFromInventory(int ItemId)
    {
        foreach (Item x in Items)
        {
            if (x.Id == ItemId)
            {
                Items.Remove(x);
                break;
            }
        }
    }

    
}
