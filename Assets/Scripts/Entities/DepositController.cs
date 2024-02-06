using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class DepositController : MonoBehaviour
{
    public InputField inputField;
    public int inputValue;
    public bool isCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Deposit10000()
    {
        if (DataManager.instance.ownedCashData >= 10000)
        {
            DataManager.instance.ownedCashData -= 10000;
            DataManager.instance.balanceCashData += 10000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
    }

    public void Deposit30000()
    {
        if (DataManager.instance.ownedCashData >= 30000)
        {
            DataManager.instance.ownedCashData -= 30000;
            DataManager.instance.balanceCashData += 30000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
    }

    public void Deposit50000()
    {
        if (DataManager.instance.ownedCashData >= 50000)
        {
            DataManager.instance.ownedCashData -= 50000;
            DataManager.instance.balanceCashData += 50000;
        }
        else
        {
            DataManager.instance.OpenWarningMenu();
        }
    }

    public void DepositInputValue()
    {
        isCount = int.TryParse(inputField.text, out int inputValue);
        if (DataManager.instance.ownedCashData >= inputValue)
        {
            DataManager.instance.ownedCashData -= inputValue;
            DataManager.instance.balanceCashData += inputValue;
        }
        else if (!isCount)
        {
            Debug.Log("숫자를 입력해주세요");
        }
        else if (DataManager.instance.ownedCashData < inputValue)
        {
            DataManager.instance.OpenWarningMenu();
        }
    }
}

