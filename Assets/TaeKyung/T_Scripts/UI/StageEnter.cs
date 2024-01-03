using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StageEnter : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private int chapterNum;
    [SerializeField] private int loadStageNum;

    public void OnPointerDown(PointerEventData eventData)
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene(chapterNum.ToString() + loadStageNum.ToString());
        Debug.Log(chapterNum.ToString() + " - " + loadStageNum.ToString());
    }
}
