using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPopupManager : MonoSingleton<SettingPopupManager>
{
    public bool currentPopupExist = true;
    [SerializeField] private GameObject[] popups;

    public void AllPopupDown()
    {
        for(int i = 0; i < popups.Length; i++)
        {
            popups[i].SetActive(false);
        }
    }
}
