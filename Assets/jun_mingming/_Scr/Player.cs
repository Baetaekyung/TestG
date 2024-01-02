using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class Player : MonoSingleton<Player>
{
    public float energy;
    public GameObject characterController;
    private void Update()
    {
        UI_Test_Gay.Instance.energy.text = "Energy : " + energy;
    }
}
