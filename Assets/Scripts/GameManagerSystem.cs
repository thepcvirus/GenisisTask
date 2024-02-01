using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSystem : MonoBehaviour
{
    public static GameManagerSystem Instance;
    public static List<Item> InventoryItems;
    public List<Item> InventoryItemsRefs;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        InventoryItems = InventoryItemsRefs;
    }
}
