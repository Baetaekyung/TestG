using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Area : MonoBehaviour
{
    public List<InteractiveObject> interactiveObjects;
    public int hp;
    private void OnTriggerEnter(Collider other)
    {
        print("a");
        if (other.gameObject.CompareTag("Player"))
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
