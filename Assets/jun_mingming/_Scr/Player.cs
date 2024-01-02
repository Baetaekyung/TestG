using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class Player : MonoSingleton<Player>
{
    public PlayerControllerScr playerControllerScr;
    public Viewmodel playerViewmodel;
    public Recorder recorder;
    public float energy;

    private void OnTriggerEnter(Collider other)
    {
        //print(other.name);
    }
}
