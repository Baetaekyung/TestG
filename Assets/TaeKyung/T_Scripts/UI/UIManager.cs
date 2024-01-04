using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class UIManager : MonoSingleton<UIManager>
{
    [SerializeField] private GameObject[] mainMenuBottons;
    [SerializeField] private GameObject exitPanel;
    [SerializeField] private List<GameObject> mainPopupPanels;
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
        AllPopUpDown();
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

    public void AllPopUpDown()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentPopupCount > 0)
            {
                for (int i = 0; i < mainPopupPanels.Count; i++)
                {
                    mainPopupPanels[i].SetActive(false);
                    exitPanel.SetActive(false);
                }
                currentPopupCount--;
            }
            else
            {
                exitPanel.SetActive(true);
                currentPopupCount++;
            }
        }
    }
}
