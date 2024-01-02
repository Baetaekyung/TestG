using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObject : MonoBehaviour
{
    public enum State
    {
        Nothing,
        Entangled
    }

    public State myState = State.Nothing;

    public Action<Vector3> onMoveChanged;

    public Vector3 beforePos;

    protected virtual void Update()
    {
        //print(transform.position);
        if (transform.position != beforePos)
        {
            onMoveChanged?.Invoke(transform.position - beforePos);
            beforePos = transform.position;
            print("movechanged");
        }
    }

    public void MovePosition(Vector3 v)
    {
        transform.Translate(v);
        beforePos = transform.position;
        print("sibal");
    }

    public void SetEntanglement(Action<Vector3> action)
    {
        print("entangled");
        action += MovePosition;
        myState = State.Entangled;
    }
    public void UnSetEntanglement(Action<Vector3> action)
    {
        print("untangled");
        action -= MovePosition;
        myState = State.Nothing;
    }
    
    
}