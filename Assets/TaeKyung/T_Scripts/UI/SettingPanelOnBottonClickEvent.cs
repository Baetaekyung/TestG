using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SettingPanelOnBottonClickEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject settingPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!settingPanel.activeSelf)
        {
            settingPanel.SetActive(true);
            UIManager.Instance.CurrentPopupCount++;
        }
    }
}
