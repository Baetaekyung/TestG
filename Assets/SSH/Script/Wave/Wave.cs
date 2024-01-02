using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public bool isObserved = false;
    public GameObject createObject;

    public bool Observed()
    {
        if (isObserved)
        {
            return true;
        }
        else
        {
            isObserved = true;
            return false;
        }
    }
}
