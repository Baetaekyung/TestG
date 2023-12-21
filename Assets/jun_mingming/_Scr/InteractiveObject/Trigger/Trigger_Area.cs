using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Area : MonoBehaviour
{
    public List<InteractiveObject> interactiveObjects;
    public int hp = 1;
    public float delay = 0;
    public bool b_enableTrigger = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && b_enableTrigger)
        {
            hp--;
            for(int i = 0; i < interactiveObjects.Count; i++)
            {
                interactiveObjects[i].Interact();
            }
            if (hp <= 0) Destroy(gameObject);
        }
    }
}
