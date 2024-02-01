using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject ItemButtonPrefabRef;
    public GameObject StoreGridUI;
    
    public Inventory InventoryRef;
    public void UpdateInventoryUI()
    {
        foreach (Transform child in StoreGridUI.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (Item x in InventoryRef.Items)
        {
            Instantiate(ItemButtonPrefabRef, Vector3.zero, Quaternion.identity, StoreGridUI.transform).GetComponent<ItemButton>().SetButtonData(x);
        }
    }

    public static void ToggleUI(GameObject UIElement)
    {
        UIElement.SetActive(!UIElement.active);
    }

}
