using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class Player : MonoSingleton<Player>
{
    public float energy;
    public GameObject characterController;
    public event Action Gay;

    protected override void Awake()
    {
        base.Awake();
        //Gay += UI_Test_Gay.Instance.UpdateEnergy;
    }
    
    public void AddEnergy(int asdad)
    {
        energy += asdad;
        Update_Energy();
    }
    public void Update_Energy()
    {
        //Gay();
    }
    protected override void OnDestroy()
    {
        base.OnDestroy();
        //Gay -= UI_Test_Gay.Instance.UpdateEnergy;//나중에고칠께 ;ㅅ;..
    }
}
