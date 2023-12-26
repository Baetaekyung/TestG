using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    [SerializeField] private GameObject[] mainMenuBottons;
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
