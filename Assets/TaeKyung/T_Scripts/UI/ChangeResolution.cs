using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeResolution : MonoBehaviour
{
    public void SetResolution_1920()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    public void SetResolution_1366()
    {
        Screen.SetResolution(1366, 768, true);
    }
}
