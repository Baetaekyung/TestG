using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Straight_Bullet : MonoBehaviour
{
    [SerializeField] private float shootForce;
    Rigidbody rigid;

    private void OnEnable()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * shootForce, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<IsWall>())
            return;
        if (collision.transform.GetComponent<PlayerControllerScr>())
        {
            string currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneName);
        }
        else
            Destroy(collision.gameObject);
    }
}
