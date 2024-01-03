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
    }
    public void UnsetEntangle(BaseObject bo)
    {
        bo.UnSetEntanglement(ref onMoveChanged);
    }
}
