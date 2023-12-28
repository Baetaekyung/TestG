using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    InputManager inputManager;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }

    private void Start()
    {
        inputManager.inputAction += Inputs;
    }

    private void OnDestroy()
    {
        inputManager.inputAction -= Inputs;
    }

    private void Inputs()
    {
        //Debug.Log("뭐 구현하지..");
    }
}
