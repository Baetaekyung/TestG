using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGun : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootPos;
    [SerializeField] private float delayTime;

    private float currentTime;

    private void Update()
    {
        MakeBullet();
    }

    private void MakeBullet()
    {
        if(currentTime <= delayTime)
        {
            currentTime += Time.deltaTime;
        }
        else
        {
            Instantiate(bullet, shootPos.position, transform.rotation);
            currentTime = 0f;
        }
    }
}
