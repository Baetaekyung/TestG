using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeThumpSOund : MonoBehaviour
{
    private bool wall = false;
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Floor"))
        {
            print("bump");
            SoundManager.Instance.PlayBigBumpSound();
        }
    }
}
