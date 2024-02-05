using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject depositMenu;
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
}
