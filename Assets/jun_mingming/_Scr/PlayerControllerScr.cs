using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScr : MonoBehaviour
{
    [Header("General")]
    [SerializeField] private Transform orientationX;
    [SerializeField] private Transform orientationY;
    [SerializeField] private Transform orientationZ;
    public int targetFrame;

    [Header("Mouse")]
    public float xSens;
    public float ySens;
    private float xRotation;
    private float yRotation;

    [Space(10)]
    public AnimationCurve bob;
    public AnimationCurve bob2;

    [Header("Movement")]
    public float speed;
    public float speedMax;

    private Vector3 direction;
    private Vector3 direction2;
    private CharacterController characterController;


    [SerializeField] private bool b_w;
    
    [SerializeField] private bool isReversing = false;//역재생하는 동안에는 이동이나 입력 불가
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        if (!isReversing)
        {
            PlayerInput();
            PlayerMouse();
            PlayerMove();
        }
        //BustMorph();
        #region debug
        if (Input.GetKeyDown(KeyCode.N))
        {
            //b_w = !b_w;
            b_w = true;
            Application.targetFrameRate = targetFrame;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Application.targetFrameRate = 30;
            b_w = false;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Cursor.visible)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
            }
        }
        #endregion
        //PlayerHud.Instance.t1.text = Input.GetAxis("Horizontal").ToString();
    }
    private void PlayerInput()
    {
        //mouse
        xRotation -= Input.GetAxisRaw("Mouse Y") * ySens;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        yRotation += Input.GetAxisRaw("Mouse X") * xSens;

        direction = orientationY.forward * Input.GetAxis("Vertical") + orientationY.right * Input.GetAxis("Horizontal");
        direction = direction.magnitude < 1 ? direction : direction.normalized;
    }
    private void PlayerMouse()
    {
        orientationX.localRotation = Quaternion.Euler(xRotation, 0, 0);
        orientationY.localRotation = Quaternion.Euler(0, yRotation, 0);
    }
    private void PlayerMove()
    {
        direction *= speed * Time.deltaTime;
        characterController.Move(direction);
        //rigidBody.velocity = direction * speed;
    }
    private void BustMorph()
    {
        //orientationZ.localRotation = Quaternion.Euler(0, 0, Mathf.Clamp(bob.Evaluate(Mathf.Abs(Input.GetAxisRaw("Mouse X"))) * -Input.GetAxisRaw("Mouse X"), -2, 2));
        orientationZ.localRotation = Quaternion.Euler(0, 0, bob.Evaluate(Mathf.Abs(Input.GetAxis("Horizontal"))) * -Input.GetAxis("Horizontal"));
    }
}
