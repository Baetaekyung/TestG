using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PastData
{
    public Vector3 position;
    public Quaternion rotation;

    public PastData(Vector3 p, Quaternion r)
    {
        position = p;
        rotation = r;
    }
}
