using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class DepositController : MonoBehaviour
{
    public int ownedCash;
    public int balanceCash;
    public InputField inputField;
    public int inputValue;
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
        if (ownedCash >= 10000)
        {
            ownedCash -= 10000;
            balanceCash += 10000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
        DataManager.instance.UpdateUI();
    }

    public void Deposit30000()
    {
        if (ownedCash >= 30000)
        {
            ownedCash -= 30000;
            balanceCash += 30000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
        DataManager.instance.UpdateUI();
    }

    public void Deposit50000()
    {
        if (ownedCash >= 50000)
        {
            ownedCash -= 50000;
            balanceCash += 50000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
        DataManager.instance.UpdateUI();
    }

    public void DepositInputValue()
    {
        inputValue = int.Parse(inputField.text);
        if (ownedCash >= inputValue)
        {
            ownedCash -= inputValue;
            balanceCash += inputValue;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
        DataManager.instance.UpdateUI();
    }
}

