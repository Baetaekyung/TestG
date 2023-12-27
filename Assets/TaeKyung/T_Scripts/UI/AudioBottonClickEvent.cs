using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AudioBottonClickEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject audioPanel;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (SettingPopupManager.Instance.currentPopupExist && !audioPanel.activeSelf)
        {
            SettingPopupManager.Instance.AllPopupDown();
            audioPanel.SetActive(true);
        }
    }
}
