using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservatingShot : MonoBehaviour
{
    public float shootSpeed;
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.forward * shootSpeed * Time.deltaTime);
    }
}
