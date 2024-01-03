using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun408 : GunBehavior
{
    public float rayRange;
    public override void Interaction0()
    {
        if(Raycast(rayRange, out RaycastHit gasdadawdada))
        {
            if(gasdadawdada.transform.TryGetComponent(out FuckBehavior adsadawwd))
            {
                adsadawwd.EnableFuck();
            }
        }
    }
    public override void Interaction1()
    {
        if (Raycast(rayRange, out RaycastHit gasdadawdada))
        {
            if (gasdadawdada.transform.TryGetComponent(out FuckBehavior adsadawwd))
            {
                adsadawwd.DisableFuck();
            }
        }
    }
}
