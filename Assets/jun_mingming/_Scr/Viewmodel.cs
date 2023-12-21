using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewmodel : MonoBehaviour
{
    public Transform cam;
    public Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.Play("Interacting");
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetTrigger("gay");
        }
    }
    private void RayTest()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit gay, 5))
        {
            //if (gay.transform.CompareTag(""))
            //{
            //
            //}
        }
    }
    private void LateUpdate()
    {
        transform.SetPositionAndRotation(cam.position, cam.rotation);
    }
}
