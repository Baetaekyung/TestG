using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Transform ad;
    void Update()
    {
        transform.LookAt(ad);
    }
}
