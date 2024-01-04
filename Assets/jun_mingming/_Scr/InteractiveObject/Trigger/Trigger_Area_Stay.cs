using UnityEngine;

public class Trigger_Area_Stay : NewBehaviourScript
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && b_enableTrigger)
        {
            InitDieTime();
        }
        if ((other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Obj")) && b_enableTrigger)
        {
            SoundManager.Instance.PlayTriggerSound();
            print("트리거했다헤ㅐ");
            HandleTrigger();
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
