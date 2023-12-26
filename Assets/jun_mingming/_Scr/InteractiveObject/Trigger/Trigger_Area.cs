using UnityEngine;

public class Trigger_Area : TriggerBehavior
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && b_enableTrigger)
        {
            HandleTrigger();
        }
    }
}
