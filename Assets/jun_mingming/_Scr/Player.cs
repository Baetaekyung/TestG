using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class Player : MonoSingleton<Player>
{
    public float energy;
        
}
