using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Recorder : MonoBehaviour
{
    private Stack<pastData> _datas;
    public bool isReversing;
    [SerializeField] private Transform positionTarget;
    [SerializeField] private Transform rotationTarget;
    [SerializeField] private Transform giveRotationTarget;
    [SerializeField] private Transform cameraPosition;
    
    private void Start()
    {
        isReversing = false;
        _datas = new Stack<pastData>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SetReverse();
            print("reverse setted");
        }
    }

    void LateUpdate()
    {
        if (isReversing == false)
        {
            _datas.Push( new pastData(positionTarget.position, rotationTarget.rotation));
            print("data pushed");
        }
        else
        {
            if (_datas.Count > 0)
            {
                print("reverse");
                pastData data = _datas.Pop();
                positionTarget.position = data.position;
                giveRotationTarget.localRotation = data.rotation;
                cameraPosition.rotation = data.rotation;
            }
            isReversing = false;
        }
    }

    public void SetReverse()
    {
        isReversing = true;//이 함수는 update에서 불러줘야함
        print("true");
    }
    
}
