using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Door2 : MonoBehaviour
{
    private bool isopen = false;
    public UnityEvent ada;
    public UnityEvent ada2;
    public void Ming()
    {
        if (!isopen)
        {
            SoundManager.Instance.PlayDoorSound();
        }
        gameObject.SetActive(false);
        ada.Invoke();
    }
    public void ReverseMing()
    {
        gameObject.SetActive(true);
        ada2.Invoke();
    }
}
