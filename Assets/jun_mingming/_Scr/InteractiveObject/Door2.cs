using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    private bool isopen = false;
    public void Ming()
    {
        if (!isopen)
        {
            SoundManager.Instance.PlayDoorSound();
        }
        gameObject.SetActive(false);
    }
}
