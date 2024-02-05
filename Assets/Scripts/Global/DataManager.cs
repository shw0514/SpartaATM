using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public DepositController depositController;
    public WithdrawController withdrawController;

    [SerializeField] private TextMeshProUGUI ownedCash;
    [SerializeField] private TextMeshProUGUI balanceCash;

    public GameObject warningMenu;

    public int ownedCashData;
    public int balanceCashData;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
        InitUserInformation();
    }

    private void InitUserInformation()
    {
        ownedCashData = 100000;
        balanceCashData = 50000;
        ownedCash.text = ownedCashData.ToString("N0");
        balanceCash.text = balanceCashData.ToString("N0");
    }

    public void UpdateUI()
    {
        ownedCash.text = depositController.ownedCash.ToString("N0");
        balanceCash.text = depositController.balanceCash.ToString("N0");
    }

    public void UpdateUI_2()
    {
        ownedCash.text = withdrawController.ownedCash.ToString("N0");
        balanceCash.text = withdrawController.balanceCash.ToString("N0");
    }

    public void OpenWarningMenu()
    {
        warningMenu.SetActive(true);
    }
}
