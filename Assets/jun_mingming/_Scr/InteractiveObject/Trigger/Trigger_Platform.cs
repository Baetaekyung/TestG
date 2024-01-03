using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Platform : TriggerBehavior
{
    public bool b_gay;
    private void OnTriggerStay(Collider other)
    {
        if((other.CompareTag("Player") || other.CompareTag("Obj")) && b_enableTrigger)
        {
            b_gay = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        print(other.name);
    }
}
