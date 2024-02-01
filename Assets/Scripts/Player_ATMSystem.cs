using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player_ATMSystem : MonoBehaviour
{
    public TMP_InputField WithdrawField;
    public TMP_InputField DepositField;

    public void Deposit()
    {
        if (DepositField.text != "")
        {
            Player_Data.Deposit(int.Parse(DepositField.text.ToString()));
            DepositField.text = "";
        }
    }

    public void Withdraw()
    {
        if (WithdrawField.text != "")
        {
            Player_Data.Withdraw(int.Parse(WithdrawField.text.ToString()));
            WithdrawField.text = "";
        }
    }

    public void ToggleUI(GameObject UIElement)
    {
        InventoryUI.ToggleUI(UIElement);
    }
}
