using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewmodel : MonoBehaviour
{
    public Transform cam;
    private void LateUpdate()
    {
        transform.SetPositionAndRotation(cam.position, cam.rotation);
    }
}
