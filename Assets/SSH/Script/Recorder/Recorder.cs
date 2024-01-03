using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-50)]
public class Recorder : MonoBehaviour
{
    private Stack<PastData> _datas;
    public bool isReversing;
    [SerializeField] private Transform positionTarget;
    [SerializeField] private Transform rotationTarget;
    public PlayerControllerScr pla;
    //[SerializeField] private Transform giveRotationTarget;
    //[SerializeField] private Transform cameraPosition;
    
    private void Start()
    {
        isReversing = false;
        _datas = new Stack<PastData>();
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
        print("이거실행");
        if (isReversing == false)
        {
            UI_Test_Gay.Instance.t2.text = rotationTarget.rotation.eulerAngles.ToString();
            pla.Gay(rotationTarget.rotation.eulerAngles);
            rotationTarget.localRotation = Quaternion.identity;
            _datas.Push(new PastData(positionTarget.position, rotationTarget.rotation));
            //print("data pushed");
        }   
        else
        {
            if (_datas.Count > 0)
            {
                // viewmodel late updae 가 빠르게 실행됨
                // Dynamic Object 에 걸릴 수 있음. Player Character Controller 프로퍼티 바꿔줘야함

                print("reverse");
                PastData data = _datas.Pop();
                positionTarget.position = data.position;
                rotationTarget.rotation = data.rotation;
                //giveRotationTarget.localRotation = data.rotation;
                //cameraPosition.rotation = data.rotation;
            }
            isReversing = false;
            pla.isReversing = false;
        }
    }

    public void SetReverse()
    {
        isReversing = true;//이 함수는 update에서 불러줘야함
        pla.isReversing = true;
        print("true");
    }
    
}
