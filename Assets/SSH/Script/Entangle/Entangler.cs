using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Entangler : BaseObject
{
    public static Entangler instance;

    private void Start()
    {
        instance = this;
    }
    public void SetEntangle(BaseObject bo)
    {
        bo.SetEntanglement(ref onMoveChanged);
        GetEntangle(bo);
    }
    public void UnsetEntangle(BaseObject bo)
    {
        bo.UnSetEntanglement(ref onMoveChanged);
        UnGetEntangle(bo);
    }

    public void GetEntangle(BaseObject bo)
    {
        SetEntanglement(ref bo.onMoveChanged);
    }
    public void UnGetEntangle(BaseObject bo)
    {
        UnSetEntanglement(ref bo.onMoveChanged);
    }
}
