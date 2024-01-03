using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : Item
{
    public override void Interaction0()
    {
        print("gun2 fire");
    }
    public override void Interaction1()
    {
        print("gun2 altfire");
    }
}
