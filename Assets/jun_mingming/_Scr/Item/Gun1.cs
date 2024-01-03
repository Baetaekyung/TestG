using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun1 : GunBehavior
{
    
    [Header("General")]
    public float rayRange;

    private BaseObject lastBaseObject;
    public override void Interaction0()
    {
        print("i1");
        
        if(Raycast(rayRange, out RaycastHit gasda))
        {
            print(gasda.transform.name);
            BaseObject a;
            if (gasda.transform.TryGetComponent<BaseObject>(out a))
            {
                if (lastBaseObject != null)
                {
                    Entangler.instance.UnsetEntangle(lastBaseObject);
                }
                Entangler.instance.SetEntangle(a);
                a.dir = 1;
                lastBaseObject = a;
                
            }
        }
    }
    public override void Interaction1()
    {
        Entangler.instance.UnsetEntangle(lastBaseObject);
        lastBaseObject = null;
        print("i2");
        if(Raycast(rayRange, out RaycastHit gasda))
        {

        }
    }

}
