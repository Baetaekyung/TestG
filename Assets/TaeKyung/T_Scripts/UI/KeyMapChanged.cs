using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyMapChanged : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TextMeshProUGUI keyValueText;
    private string defaultKeyValue = " ";

    private void Start()
    {
        defaultKeyValue = keyValueText.text;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        keyValueText.text = " ";
        StartCoroutine(KeyMap());
    }
    
    private IEnumerator KeyMap()
    {
        yield return new WaitUntil(() => Input.anyKeyDown);
        keyValueText.text = Input.inputString.ToUpper();
    }
}
