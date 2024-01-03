using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GunBehavior : Item
{
    protected virtual bool Raycast(float range, out RaycastHit ga)
    {
        if (Viewmodel.Instance.ShootRay(range, out ga))
        {
            return true;
        }
        else return false;
    }
}
