using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class InputManager : MonoBehaviour
{
    public Action inputAction;

    private void InputSystem()
    {
        if (Input.anyKeyDown)
        {
            inputAction?.Invoke();
        }
    }

    private void Start()
    {
        inputAction += Test;
        print(name);
    }

    private void Update()
    {
        InputSystem();
    }

    private void Test()
    {
        Debug.Log("입력을 받다...");
    }
}
