using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuck2 : FuckBehavior
{
    public float a;
    private void Update()
    {
        a += Time.deltaTime;
    }
    private void FixedUpdate()
    {
        dir = playerDir;
        dir.x = 0;
        dir.z = 0;
        dir.y = rigidBody.velocity.y;
        rigidBody.velocity = dir;
    }
    public override void EnableFuck()
    {
        base.EnableFuck();
        rigidBody.useGravity = true;
        a = 0;
    }
    public override void DisableFuck()
    {
        base.DisableFuck();
        rigidBody.useGravity = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        PlayerControllerScr.Instance.PlayerJump(a * speed);
        print(a * speed);
        DisableFuck();
    }
}
