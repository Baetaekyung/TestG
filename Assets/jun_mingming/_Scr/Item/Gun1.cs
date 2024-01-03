using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun1 : GunBehavior
{
    [Header("General")]
    public float rayRange;

    public override void Interaction0()
    {
        print("i1");
        if(Raycast(rayRange, out RaycastHit gasda))
        {
            print(gasda.transform.name);

        }
    }
    public override void Interaction1()
    {
        print("i2");
        if(Raycast(rayRange, out RaycastHit gasda))
        {

        }
    }

}
