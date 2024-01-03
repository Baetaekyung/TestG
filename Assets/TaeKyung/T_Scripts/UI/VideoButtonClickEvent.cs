using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VideoButtonClickEvent : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private GameObject videoPanel;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (SettingPopupManager.Instance.currentPopupExist && !videoPanel.activeSelf)
        {
            SettingPopupManager.Instance.AllPopupDown();
            videoPanel.SetActive(true);
        }
    }
}
