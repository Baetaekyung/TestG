using UnityEngine;

public class Trigger_Area_Stay : NewBehaviourScript
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && b_enableTrigger)
        {
            InitDieTime();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Obj")) && b_enableTrigger)
        {
            HandleTrigger();
        }
    }
}
