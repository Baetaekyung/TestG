using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuck9 : FuckBehavior
{
    public static Vector3 ming;
    private void Update()
    {
        ming = transform.position - ming;
        print(ming);
        ming = transform.position;
    }
    public override void EnableFuck()
    {
        base.EnableFuck();
        ming = transform.position;
        ming = transform.position - ming;
    }
    public override void DisableFuck()
    {
        base.DisableFuck();

    }
}
