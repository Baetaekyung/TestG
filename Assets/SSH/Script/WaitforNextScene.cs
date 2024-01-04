using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitforNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(GoBackToMainMenu), 3f);
    }

    void GoBackToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
