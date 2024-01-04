using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun408 : GunBehavior
{
    public GameObject showRange;
    public float rayRange;
    public string animationName;
    public override void Interaction0()
    {
        SoundManager.Instance.PlayShootSound();
        Viewmodel.Instance.PlayAnimation(animationName);
        //GameObject ag = Instantiate(showRange, transform.position, Quaternion.identity);
        //Debug.DrawRay(transform.position, Viewmodel.Instance.transform.forward * 1 * rayRange, Color.white, 8);
        //ag.transform.LookAt(Viewmodel.Instance.gay);
        //ag.transform.parent = null;
        //VisualizeGunRange.Instance.Visualize(rayRange, showRange, Viewmodel.Instance.transform);
        if(Raycast(rayRange, out RaycastHit gasdadawdada))
        {
            if(gasdadawdada.transform.TryGetComponent(out FuckBehavior adsadawwd))
            {
                adsadawwd.EnableFuck();
                SoundManager.Instance.PlayHitSound();
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

        //VisualizeGunRange.Instance.Visualize(rayRange, showRange, Viewmodel.Instance.transform);
        if (Raycast(rayRange, out RaycastHit gasdadawdada))
        {
            if (gasdadawdada.transform.TryGetComponent(out FuckBehavior adsadawwd))
            {
                SoundManager.Instance.PlayHitSound();
                adsadawwd.DisableFuck();
            }
        }
    }

}
