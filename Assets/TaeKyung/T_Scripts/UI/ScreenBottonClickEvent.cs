using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScreenBottonClickEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject screenPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (SettingPopupManager.Instance.currentPopupExist && !screenPanel.activeSelf)
        {
            SettingPopupManager.Instance.AllPopupDown();
            screenPanel.SetActive(true);
        }
    }
}
