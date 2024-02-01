using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Data : MonoBehaviour
{
    public static int BankBalance = 3000;
    public static int Coins = 1000;
    static Inventory Player_Inventory;
    public static Store_InventoryUI CurrentChoosenStoreUI;
    public static Player_InventoryUI CurrentInventoryUI;

    private void Start()
    {
        Player_Inventory = transform.GetComponent<Inventory>();
    }

    public static bool Buy(Item item)
    {
        if (Coins >= item.Price)
        {
            Coins -= item.Price;
            Player_Inventory.AddToInventory(item.Id);
            CurrentChoosenStoreUI.InventoryRef.RemoveFromInventory(item.Id);
            CurrentChoosenStoreUI.UpdateInventoryUI();
            CurrentInventoryUI.UpdateInventoryUI();
            UIManager.Instance.UpdateCoinsUI();
        }
        else
            return false;
        return true;
    }

    public static bool Sell(Item item)
    {
        if (CurrentChoosenStoreUI != null)
        {
            Coins += item.Price;
            Player_Inventory.RemoveFromInventory(item.Id);
            CurrentChoosenStoreUI.InventoryRef.AddToInventory(item.Id);
            CurrentChoosenStoreUI.UpdateInventoryUI();
            CurrentInventoryUI.UpdateInventoryUI();
            UIManager.Instance.UpdateCoinsUI();
            return true;
        }

        return false;
    }

    public static void Deposit(int DepCoins)
    {
        if (DepCoins <= Player_Data.Coins)
        {
            Coins -= DepCoins;
            BankBalance += DepCoins;
            UIManager.Instance.UpdateCoinsUI();
            UIManager.Instance.UpdateBalanceUI();
        }
    }

    public static void Withdraw(int WithCoins)
    {
        if (WithCoins <= Player_Data.BankBalance)
        {
            Coins += WithCoins;
            BankBalance -= WithCoins;
            UIManager.Instance.UpdateCoinsUI();
            UIManager.Instance.UpdateBalanceUI();
        }
    }

    public static void BankBonus()
    {
        BankBalance = (int)(BankBalance * 1.1f);
        UIManager.Instance.UpdateBalanceUI();
    }
}
