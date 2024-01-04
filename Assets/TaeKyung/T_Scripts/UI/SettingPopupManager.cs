using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class SettingPopupManager : MonoSingleton<SettingPopupManager>
{
    public bool currentPopupExist = true;
    [SerializeField] private GameObject[] popups;

    protected override void Awake()
    {
        base.Awake();
    }

    public void AllPopupDown()
    {
        for(int i = 0; i < popups.Length; i++)
        {
            popups[i].SetActive(false);
        }
    }
}
