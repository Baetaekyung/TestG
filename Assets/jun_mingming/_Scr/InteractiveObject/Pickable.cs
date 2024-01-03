using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public Rigidbody rigidBody;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    public void PickUp()
    {
        rigidBody.constraints = RigidbodyConstraints.None;
        rigidBody.useGravity = false;
        rigidBody.constraints |= RigidbodyConstraints.FreezeRotationX;
        rigidBody.constraints |= RigidbodyConstraints.FreezePositionY;
        rigidBody.constraints |= RigidbodyConstraints.FreezeRotationZ;
    }

}
