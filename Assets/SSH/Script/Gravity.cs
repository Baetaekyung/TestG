using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Vector3 gravityVector3;
    private bool iscolliding = false;

    private void OnCollisionEnter(Collision other)
    {
        iscolliding = true;
    }

    private void OnCollisionExit(Collision other)
    {
        iscolliding = false;
    }

    void Update()
    {
        if(!iscolliding)   
        transform.Translate(gravityVector3 * Time.deltaTime);
    }
}
