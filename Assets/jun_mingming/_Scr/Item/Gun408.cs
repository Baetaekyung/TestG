using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun408 : GunBehavior
{
    public float rayRange;
    public string animationName;
    public override void Interaction0()
    {
        Viewmodel.Instance.PlayAnimation(animationName);

        if(Raycast(rayRange, out RaycastHit gasdadawdada))
        {
            if(gasdadawdada.transform.TryGetComponent(out FuckBehavior adsadawwd))
            {
                adsadawwd.EnableFuck();
            }
            else if(gasdadawdada.transform.TryGetComponent(out Trigger_Raycast2 a))
            {
                a.HandleTrigger();
            }
        }
    }
    public override void Interaction1()
    {
        Viewmodel.Instance.PlayAnimation(animationName);

        if (Raycast(rayRange, out RaycastHit gasdadawdada))
        {
            if (gasdadawdada.transform.TryGetComponent(out FuckBehavior adsadawwd))
            {
                adsadawwd.DisableFuck();
            }
        }
    }

}
