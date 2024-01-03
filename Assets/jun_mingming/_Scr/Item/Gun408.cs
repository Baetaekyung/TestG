using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun408 : GunBehavior
{
    public float rayRange;
    public Fuck cash = null;
    public override void Interaction0()
    {
        if(Raycast(rayRange, out RaycastHit gasdadawdada))
        {
            if(gasdadawdada.transform.TryGetComponent(out Fuck adsadawwd))
            {
                adsadawwd.EnableFuck();
                cash = adsadawwd;
            }
        }
    }
    public override void Interaction1()
    {
        cash.DisableFuck();
    }
}
