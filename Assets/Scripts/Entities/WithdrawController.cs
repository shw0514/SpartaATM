using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawController : MonoBehaviour
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

    public void Withdraw10000()
    {
        if (balanceCash >= 10000)
        {
            ownedCash += 10000;
            balanceCash -= 10000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
        DataManager.instance.UpdateUI_2();
    }

    public void Withdraw30000()
    {
        if (balanceCash >= 30000)
        {
            ownedCash += 30000;
            balanceCash -= 30000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
        DataManager.instance.UpdateUI_2();
    }

    public void Withdraw50000()
    {
        if (balanceCash >= 50000)
        {
            ownedCash += 50000;
            balanceCash -= 50000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
        DataManager.instance.UpdateUI_2();
    }

    public void WithdrawInputValue()
    {
        inputValue = int.Parse(inputField.text);
        if (balanceCash >= inputValue)
        {
            ownedCash += inputValue;
            balanceCash -= inputValue;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
        DataManager.instance.UpdateUI_2();
    }
}
