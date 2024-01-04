using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Vector3 gravityVector3;
    private bool iscolliding = false;
    private Rigidbody rg;
    private void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

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
        if (!iscolliding)
        {
            rg.velocity=gravityVector3;
        }
        else
        {
            rg.velocity = Vector3.zero;
        }
    }
}
