using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawController : MonoBehaviour
{
    public InputField inputField;
    public int inputValue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Withdraw10000()
    {
        if (DataManager.instance.balanceCashData >= 10000)
        {
            DataManager.instance.ownedCashData += 10000;
            DataManager.instance.balanceCashData -= 10000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
    }

    public void Withdraw30000()
    {
        if (DataManager.instance.balanceCashData >= 30000)
        {
            DataManager.instance.ownedCashData += 30000;
            DataManager.instance.balanceCashData -= 30000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
    }

    public void Withdraw50000()
    {
        if (DataManager.instance.balanceCashData >= 50000)
        {
            DataManager.instance.ownedCashData += 50000;
            DataManager.instance.balanceCashData -= 50000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
    }

    public void WithdrawInputValue()
    {
        bool isNumeral = int.TryParse(inputField.text, out int inputValue);

        if (isNumeral)
        {
            if (DataManager.instance.balanceCashData >= inputValue)
            {
                DataManager.instance.ownedCashData += inputValue;
                DataManager.instance.balanceCashData -= inputValue;
            }
            else if (DataManager.instance.balanceCashData < inputValue)
            {
                DataManager.instance.OpenWarningMenu();
            }
        }
        else
        {
            Debug.Log("숫자를 입력해주세요");
        }

    }
}

