using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Gaygun : GunBehavior
{
    [SerializeField] private float gunRange;

    public override void Interaction0()
    {
        base.Interaction0();
        if(Raycast(gunRange, out RaycastHit hit))
        {
            if (hit.transform.TryGetComponent(out Respawn r))
            {
                r.InstantiateBox(); 
                SoundManager.Instance.PlayTriggerSound();
            }
            else if(hit.transform.TryGetComponent(out MingMingMing mingMingMing))
            {
                mingMingMing.GayFuckNo();
            }
        }
    }
}
