using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TMP_Text CoinsUI;
    public TMP_Text BalanceUI;

    private void Start()
    {
        Instance = this;
        UpdateBalanceUI();
        UpdateCoinsUI();
    }

    public void UpdateCoinsUI()
    {
        CoinsUI.SetText("" + Player_Data.Coins);
    }

    public void UpdateBalanceUI()
    {
        BalanceUI.SetText("" + Player_Data.BankBalance);
    }
}
