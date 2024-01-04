using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public void Open()
    {
        transform.rotation = Quaternion.Euler(-90, 300, 0);
    }
    public void Close()
    {
        transform.rotation = Quaternion.Euler(-90, 90, 0);
    }

}
