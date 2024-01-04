using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isopen = false;
    public void Open()
    {
        transform.rotation = Quaternion.Euler(-90, 300, 0);
        if (!isopen)
        {
            SoundManager.Instance.PlayDoorSound();
            isopen = true;
        }
    }
    public void Close()
    {
        isopen = false;
        transform.rotation = Quaternion.Euler(-90, 90, 0);
    }

}
