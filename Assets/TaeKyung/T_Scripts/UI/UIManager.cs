using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    [SerializeField] private GameObject[] mainMenuBottons;
    private int currentPopupCount = 0;
    public int CurrentPopupCount
    {
        get => currentPopupCount;
        set
        {
            currentPopupCount = Mathf.Clamp(value, 0, 10);
        }
    }

    private void Update()
    {
        if(CurrentPopupCount == 0)
        {
            AllBottonActiveTrue();
        }
        else if(currentPopupCount > 0)
        {
            AllBottonActiveFalse();
        }
    }

    public void AllBottonActiveFalse()
    {
        for(int index = 0; index < mainMenuBottons.Length; index++)
        {
            mainMenuBottons[index].SetActive(false);
        }
    }

    public void AllBottonActiveTrue()
    {
        for (int index = 0; index < mainMenuBottons.Length; index++)
        {
            mainMenuBottons[index].SetActive(true);
        }
    }
}
