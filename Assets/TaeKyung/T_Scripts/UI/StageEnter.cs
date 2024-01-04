using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StageEnter : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private string StageName;

    public void OnPointerDown(PointerEventData eventData)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(StageName);
        
    }
}
