using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showRange : MonoBehaviour
{
    private void OnEnable()
    {
        Destroy(this.gameObject, 1f);
    }
}
