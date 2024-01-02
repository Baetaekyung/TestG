using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observation : MonoBehaviour
{
    private Camera mainCam;
    public GameObject shoot;
    
    public int fovValue;
    public float basefovValue;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        basefovValue = Camera.main.fieldOfView;
    }

    private Ray ray;
    private RaycastHit rayhit;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Camera.main.fieldOfView = fovValue;
            Debug.DrawRay(transform.position, transform.forward, Color.red, 5);
            ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out rayhit))
            {
                print("rayHit");
                Wave wave = rayhit.transform.GetComponent<Wave>();
                if (!wave.Observed())
                {
                    print("waveMade");
                    Instantiate(wave.createObject, rayhit.point, Quaternion.identity);
                }
            }
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            Camera.main.fieldOfView = basefovValue;
        }
    }
}
