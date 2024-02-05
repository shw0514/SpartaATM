using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject depositMenu;
    public GameObject withdrawMenu;
    public GameObject warningMenu;
    public void OpenDepositMenu()
    {
        depositMenu.SetActive(true);
    }
    
    public void CloseDepositMenu()
    {
        depositMenu.SetActive(false);
    }

    public void CloseWarningMenu()
    {
        warningMenu.SetActive(false);
    }

    public void OpenWithdrawMenu()
    {
        withdrawMenu.SetActive(true);
    }

    public void CloseWithdrawMenu()
    {
        withdrawMenu.SetActive(false);
    }
}
