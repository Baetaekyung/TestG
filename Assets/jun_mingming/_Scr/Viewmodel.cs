using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewmodel : MonoBehaviour
{
    public Transform cam;
    public Animator animator;
    public float rayFuck;
    private bool b_gay = false;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        //RayTest();
    }
    private void LateUpdate()
    {
        transform.SetPositionAndRotation(cam.position, cam.rotation);
    }
    private void RayTest()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit gay, rayFuck))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.DrawRay(transform.position, transform.forward * rayFuck, Color.red, 5);
                if (gay.transform.TryGetComponent(out Trigger_Raycast ming))
                {
                    animator.Play("Interacting");
                    ming.HandleTrigger();
                    b_gay = true;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.E) && b_gay)
        {
            CancelInteract();
        }
    }
    private void CancelInteract()
    {
        print("cancelInteract");
        animator.SetTrigger("gay");
        b_gay = false;
    }
}
