using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExitBottonClickEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image exitPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        exitPanel.gameObject.SetActive(true);
        UIManager.Instance.AllBottonActiveFalse();
    }
}
