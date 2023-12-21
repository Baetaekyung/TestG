using UnityEngine;
using System.Collections.Generic;

public class Trigger_Raycast : MonoBehaviour
{
    public List<InteractiveObject> interactiveObjects;
    public int hp = 1;
    public float delay = 0;
    public bool b_enableTrigger = true;
    public void Trigger()
    {
        for(int i = 0; i < interactiveObjects.Count; i++)
        {
            interactiveObjects[i].Interact();
        }
    }
    //fuck you
}
