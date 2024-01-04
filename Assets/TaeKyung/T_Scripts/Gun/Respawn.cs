using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private FuckBehavior box;

    public void InstantiateBox()
    {
        box.transform.position = transform.position;
        box.DisableFuck();
    }
}
