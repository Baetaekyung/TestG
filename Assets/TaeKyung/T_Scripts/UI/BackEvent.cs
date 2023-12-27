using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackEvent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject currentPanel;
    public void OnPointerClick(PointerEventData eventData)
    {
        BackEventFunc();
    }

    private void BackEventFunc()
    {
        UIManager.Instance.CurrentPopupCount--;
        currentPanel.SetActive(false);
    }
}
