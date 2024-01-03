using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(10)]
public class Fuck : MonoBehaviour
{
    public bool b_enablePlayerEffect;
    public Rigidbody rigidBody;
    public float speed;
    public Vector3 dir;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rigidBody.velocity = dir;
    }
    public void FuckGravity()
    {
        rigidBody.useGravity = false;
    }
    public void NotFuckGravity()
    {
        rigidBody.useGravity = true;
    }
    public void EnableFuck()
    {

    }
    public void DisableFuck()
    {

    }
}
