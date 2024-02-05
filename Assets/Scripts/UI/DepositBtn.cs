using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositBtn : MonoBehaviour
{
    public GameObject depositMenu;
    public void OpenDepositMenu()
    {
        depositMenu.SetActive(true);
    }
}
