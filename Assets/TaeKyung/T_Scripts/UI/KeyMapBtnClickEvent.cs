using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyMapBtnClickEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject keyMapPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (keyMapPanel != null)
        {
            if(!keyMapPanel.activeSelf && SettingPopupManager.Instance.currentPopupExist)
            {
                SettingPopupManager.Instance.AllPopupDown();
                keyMapPanel.SetActive(true);
            }
        }
    }
}
