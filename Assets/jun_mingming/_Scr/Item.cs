using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
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
}