using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straight_Bullet : MonoBehaviour
{
    [SerializeField] private float shootForce;
    Rigidbody rigid;

    private void OnEnable()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * shootForce, ForceMode.Force);
    }
}