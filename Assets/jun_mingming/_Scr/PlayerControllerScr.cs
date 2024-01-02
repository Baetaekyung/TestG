using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScr : MonoBehaviour
{
    [Header("General")]
    [SerializeField] private Transform orientationX;
    [SerializeField] private Transform orientationY;
    [SerializeField] private Transform orientationZ;
    public int targetFrame;//d

    [Header("Mouse")]
    public float xSens;
    public float ySens;
    private float xRotation;
    private float yRotation;

    [Space(10)]
    public AnimationCurve bob;
    public AnimationCurve bob2;

    [Header("Movement")]
    public float speedWalk;
    public float speedRun;
    public float speedMax;//
    public float gravity;
    public float _yVal;
    private float speed;

    public float jumpForce;
    public bool b_running;

    private Vector3 direction;
    private Vector3 direction2;//
    private CharacterController characterController;

    [SerializeField] private bool b_w;
    public bool isReversing = false;//역재생하는 동안에는 이동이나 입력 불가
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        speed = speedWalk;
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
        if (Input.GetKey(KeyCode.Backspace))
        {
        }
        UI_Test_Gay.Instance.t1.text = orientationZ.rotation.eulerAngles.ToString();
        //UI_Test_Gay.Instance.t2.text = orientationY.localRotation.y.ToString();
        //UI_Test_Gay.Instance.t3.text = orientationZ.localRotation.z.ToString();
        #endregion
        //PlayerHud.Instance.t1.text = Input.GetAxis("Horizontal").ToString();
    }
    private void PlayerInput()
    {
        //mouse
        xRotation -= Input.GetAxisRaw("Mouse Y") * ySens;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        yRotation += Input.GetAxisRaw("Mouse X") * xSens;

        //keys
        //dir
        direction = orientationY.forward * Input.GetAxis("Vertical") + orientationY.right * Input.GetAxis("Horizontal");
        direction = direction.magnitude < 1 ? direction : direction.normalized;

        //space/jump
        if (Input.GetKeyDown(KeyCode.Space) && characterController.isGrounded)
        {
            PlayerJump();
        }

        //speedLogic
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            b_running = true;
            speed = speedRun;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            b_running = false;
            speed = speedWalk;
        }
    }
    private void PlayerMouse()
    {
        orientationX.localRotation = Quaternion.Euler(xRotation, 0, 0);
        orientationY.localRotation = Quaternion.Euler(0, yRotation, 0);
    }
    private void PlayerMove()
    {
        direction *= speed;
        PlayerAdditionalPhysics();
        direction *= Time.deltaTime;
        characterController.Move(direction);
    }
    private void PlayerAdditionalPhysics()
    {
        if (characterController.isGrounded && _yVal < 0)
        {
            _yVal = -1;
        }
        else
        {
            _yVal += gravity * Time.deltaTime; //현실적인 중력 만들기... 좆나 빨리 떨어짐
        }
        direction.y = _yVal;
    }
    private void PlayerJump()
    {
        //_yVal += jumpForce;
        _yVal = Mathf.Sqrt(jumpForce);
    }
    private void BustMorph()
    {
        //orientationZ.localRotation = Quaternion.Euler(0, 0, Mathf.Clamp(bob.Evaluate(Mathf.Abs(Input.GetAxisRaw("Mouse X"))) * -Input.GetAxisRaw("Mouse X"), -2, 2));
        orientationZ.localRotation = Quaternion.Euler(0, 0, bob.Evaluate(Mathf.Abs(Input.GetAxis("Horizontal"))) * -Input.GetAxis("Horizontal"));
    }


    public void Gay(Vector3 gay)
    {
        xRotation = gay.x >= 270 ? gay.x - 360 : gay.x;
        yRotation = gay.y;
        PlayerMouse();
    }
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
    }
}
