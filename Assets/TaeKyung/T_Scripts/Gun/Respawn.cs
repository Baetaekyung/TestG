using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform firstTransform;
    [SerializeField] private FuckBehavior box;

    private void Start()
    {
        firstTransform = transform;
    }

    public void InstantiateBox()
    {
        box.transform.position = transform.position;
        box.DisableFuck();
    }
}
