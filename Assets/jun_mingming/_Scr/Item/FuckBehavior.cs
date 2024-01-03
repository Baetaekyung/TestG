using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FuckBehavior : MonoBehaviour
{
    [Header("General")]
    public Rigidbody rigidBody;
    public float speed;
    public static Vector3 playerDir;
    public Vector3 dir; 
    protected virtual void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    public virtual void EnableFuck()
    {
        enabled = true;
    }
    public virtual void DisableFuck()
    {
        enabled = false;
        rigidBody.velocity = Vector3.zero;
    }
}
