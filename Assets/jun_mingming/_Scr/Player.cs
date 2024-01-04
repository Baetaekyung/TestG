using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class Player : MonoSingleton<Player>
{
    public float energy;
    public float energyMax;
    public int coin;
    public GameObject characterController;
    public event Action Gay;

    protected override void Awake()
    {
        base.Awake();
        //Gay += UI_Test_Gay.Instance.UpdateEnergy;
        energy = energyMax;
    }
    private void Start()
    {
        Update_Energy();
    }
    public void AddCoin(int a)
    {
        coin += a;
    }
    public bool CanJump()
    {
        return energy > 0;
    }
    public void SetEnergyMax()
    {
        energy = energyMax;
        Update_Energy();
    }
    public void AddEnergy(int asdad)
    {
        energy += asdad;
        Update_Energy();
    }
    public void AddEnergyMax(int asdaa)
    {
        energyMax += asdaa;
        Update_Energy();
    }
    public void Update_Energy()
    {
        UI_Test_Gay.Instance.UpdateEnergy();
        Gay?.Invoke();
    }
    protected override void OnDestroy()
    {
        base.OnDestroy();
        //Gay -= UI_Test_Gay.Instance.UpdateEnergy;//나중에고칠께 ;ㅅ;..
    }
}
