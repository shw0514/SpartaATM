using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class DepositController : MonoBehaviour
{
    private int ownedCash;
    private int balanceCash;
    // Start is called before the first frame update
    void Start()
    {
        ownedCash = DataManager.instance.ownedCashData;
        balanceCash = DataManager.instance.balanceCashData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Deposit10000()
    {
        ownedCash -= 10000;
        balanceCash += 10000;
        if (ownedCash < 10000)
        {
            DataManager.instance.OpenWarningMenu();
        }
    }
}
