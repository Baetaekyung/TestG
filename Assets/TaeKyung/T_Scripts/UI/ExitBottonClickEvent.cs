using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExitBottonClickEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject exitPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!exitPanel.activeSelf)
        {
            exitPanel.gameObject.SetActive(true);
            UIManager.Instance.CurrentPopupCount++;
        }
    }
}
