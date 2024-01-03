using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuck : FuckBehavior
{
    private void FixedUpdate()
    {
        dir = playerDir;
        dir.x = 0;
        dir.z = 0;
        dir.y *= -1;
        rigidBody.velocity = dir;
    }
}
