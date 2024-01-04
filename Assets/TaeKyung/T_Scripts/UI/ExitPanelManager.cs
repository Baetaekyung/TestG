using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPanelManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panel.activeSelf)
            {
                Cursor.lockState = CursorLockMode.Locked;
                panel.SetActive(false);
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                panel.SetActive(true);
            }
        }
    }
}
