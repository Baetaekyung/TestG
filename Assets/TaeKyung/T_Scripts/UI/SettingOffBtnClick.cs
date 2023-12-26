using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SettingOffBtnClick : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private RectTransform settingPanelTransform;
    [SerializeField] private float toOffTime = 1f;
    private float elapsTime = 0f;

    public void OnPointerDown(PointerEventData eventData)
    {
        StartCoroutine(SettingPanelOff());
    }

    private IEnumerator SettingPanelOff()
    {
        while (elapsTime < toOffTime)
        {
            elapsTime += Time.deltaTime;
            float t = elapsTime / toOffTime;
            settingPanelTransform.localScale = Vector3.Lerp(settingPanelTransform.localScale,
                Vector3.zero, t);
            yield return new WaitForSeconds(0.015f);
        }
        elapsTime = 0f;
    }
}
