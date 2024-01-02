using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChapterClickEvent : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private string chapterNameToLoad;

    public void OnPointerDown(PointerEventData eventData)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(chapterNameToLoad);
    }
}
