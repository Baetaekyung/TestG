using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartBottonClickEvent : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private string sceneNameToLoad;
    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}


