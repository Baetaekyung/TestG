using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript2 : NewBehaviourScript1
{
    public Collider collider2;
    public Material transperMat;
    private Material unTransperMat;
    private MeshRenderer meshRenderer;
    public float val;
    public override void Awake()
    {
        Player.Instance.Gay += HandleCollider;
        meshRenderer = GetComponent<MeshRenderer>();
        unTransperMat = meshRenderer.material;
    }
    public override void OnDestroy()
    {
        Player.Instance.Gay -= HandleCollider;//나중에고칠께 ;ㅅ;..
    }
    private void HandleCollider()
    {
        if(Player.Instance.energy > val)
        {
            DisableCollision();
        }
        else
        {
            EnableCollision();
        }
    }
    private void DisableCollision()
    {
        collider2.isTrigger = true;
        meshRenderer.material = unTransperMat;
    }
    private void EnableCollision()
    {
        collider2.isTrigger = false;
        meshRenderer.material = transperMat;
    }
}
