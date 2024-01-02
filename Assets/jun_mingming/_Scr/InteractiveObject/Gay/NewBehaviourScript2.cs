using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : NewBehaviourScript1
{
    public Collider collider2;
    public float val;
    public override void Awake()
    {
        Player.Instance.Gay += HandleCollider; 
    }
    public override void OnDestroy()
    {
        Player.Instance.Gay -= HandleCollider;
    }
    private void HandleCollider()
    {
        if(Player.Instance.energy > val)
        {
            collider2.isTrigger = true;
        }
        else
        {
            collider2.isTrigger = false;
        }
    }
}
