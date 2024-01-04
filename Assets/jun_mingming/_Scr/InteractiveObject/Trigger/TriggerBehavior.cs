using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

public abstract class TriggerBehavior : MonoBehaviour
{
    [Header("General")]
    //public List<InteractiveObject> interactiveObjects;
    public UnityEvent interact;
    public int hp = 1;
    public float delay = 0;
    public bool b_enableTrigger = true;
    
    [Header("Destroy")]
    public TriggerType triggerType = TriggerType.Destroy;
    public List<Component> componentDestroy;
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


    
    private bool istriggered = false;
    public virtual void Trigger()
    {
        if (!istriggered)
        {
            SoundManager.Instance.PlayTriggerSound();
            istriggered = true;
        }
        hp--;
        interact.Invoke();
        //for (int i = 0; i < interactiveObjects.Count; i++)
        //{
        //    interactiveObjects[i].Interact();
        //}
        b_enableTrigger = true;
        if (hp <= 0)
        {
            if (triggerType == TriggerType.DontDestroy) return;
            if(triggerType == TriggerType.Destroy)
            {
                Destroy(gameObject);
            }
            else if (triggerType == TriggerType.DestroyComponent)
            {
                Destroy(this);
            }
            DestroyGay();
        }
    }
    private void DestroyGay()
    {
        for(int i = 0; i < componentDestroy.Count; i++)
        {
            Destroy(componentDestroy[i]);
        }
    }
    
}