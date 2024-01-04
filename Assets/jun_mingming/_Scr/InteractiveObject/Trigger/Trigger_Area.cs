using UnityEngine;

public class Trigger_Area : TriggerBehavior
{
    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player") || other.gameObject.CompareTag("Obj")) && b_enableTrigger)
        {
            HandleTrigger();
        }
    }
}
