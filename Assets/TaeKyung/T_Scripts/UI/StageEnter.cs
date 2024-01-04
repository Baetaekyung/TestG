using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StageEnter : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private int loadStageNum;

    public void OnPointerDown(PointerEventData eventData)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Puzzle"+loadStageNum.ToString());
        
    }
}
