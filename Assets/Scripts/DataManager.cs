using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    [SerializeField] private TextMeshProUGUI ownedCash;
    [SerializeField] private TextMeshProUGUI balanceCash;
    private int ownedCashData;
    private int balanceCashData;
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
}