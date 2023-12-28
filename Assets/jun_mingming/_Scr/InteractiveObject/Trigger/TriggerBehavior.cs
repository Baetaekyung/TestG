using System.Collections.Generic;
using UnityEngine;
public abstract class TriggerBehavior : MonoBehaviour
{
    [Header("General")]
    public List<InteractiveObject> interactiveObjects;
    public int hp = 1;
    public float delay = 0;
    public bool b_enableTrigger = true;
    public virtual void HandleTrigger()
    {
        print("beha");
        if(delay <= 0)
        {
            Trigger();
        }
        else
        {
            Invoke(nameof(Trigger), delay);
            b_enableTrigger = false;
        }
    }
    public virtual void Trigger()
    {
        hp--;
        for (int i = 0; i < interactiveObjects.Count; i++)
        {
            interactiveObjects[i].Interact();
        }
        b_enableTrigger = true;
        if (hp <= 0) Destroy(gameObject);
    }
    
}