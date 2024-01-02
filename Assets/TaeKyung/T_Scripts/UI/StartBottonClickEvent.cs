using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartBottonClickEvent : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private GameObject chapterSelectPanel;
    public void OnPointerDown(PointerEventData eventData)
    {
        chapterSelectPanel.SetActive(true);
        UIManager.Instance.CurrentPopupCount++;
    }
}


