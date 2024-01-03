using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve_Bullet : MonoBehaviour
{
    [SerializeField] private float shootForce;
    Rigidbody rigid;

    private void OnEnable()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * shootForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<IsWall>())
            return;
        if (collision.transform.GetComponent<Player>())
        {
            string currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneName);
        }
        else
            Destroy(collision.gameObject);
    }
}
