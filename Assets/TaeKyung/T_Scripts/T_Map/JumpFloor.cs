using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFloor : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.GetComponent<PlayerControllerScr>())
        {
            PlayerControllerScr playerController = collision.transform.GetComponent<PlayerControllerScr>();
            playerController._yVal = 0;
            playerController._yVal = Mathf.Sqrt(jumpForce);
        }
        else
        {
            return;
        }
    }
}
