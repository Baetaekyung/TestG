using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Entangler : BaseObject
{
    public BaseObject _baseObject;
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.G))
        {
            _baseObject.SetEntanglement(onMoveChanged);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            _baseObject.UnSetEntanglement(onMoveChanged);
        }
    }

    // void Update()
    // {
    //     
    //     if (Input.GetKeyDown(KeyCode.G))
    //     {
    //         _baseObject.SetEntanglement(onMoveChanged);
    //     }
    //     if (Input.GetKeyDown(KeyCode.H))
    //     {
    //         _baseObject.UnSetEntanglement(onMoveChanged);
    //     }
    //     
    // }
}