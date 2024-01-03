using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [Header("General")]
    public Vector3 offset;

    [Header("Delay")]
    public float delayEquip;
    public float delayUnequip;
    public virtual void Equip()
    {
        gameObject.SetActive(true);
    }
    public virtual void Unequip()
    {
        gameObject.SetActive(false);
    }
    public virtual void Interaction0()
    {
    }
    public virtual void Interaction1()
    {

    }
    public void AddItem()
    {
        Inventory.Instance.AddItem(this);
    }
}