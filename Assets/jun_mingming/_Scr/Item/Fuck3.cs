using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuck3 : FuckBehavior
{
    private void FixedUpdate()
    {
        dir = playerDir;
        rigidBody.velocity = dir;
    }
}
