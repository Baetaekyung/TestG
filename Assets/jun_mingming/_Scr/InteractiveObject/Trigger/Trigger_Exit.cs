using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Exit : TriggerBehavior
{
    private void OnTriggerExit(Collider other)
    {
        if((other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Obj")) && b_enableTrigger)
        HandleTrigger();
    }
}
