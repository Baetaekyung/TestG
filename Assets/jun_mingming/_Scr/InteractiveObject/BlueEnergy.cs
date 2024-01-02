using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnergy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("a");
        if(other.gameObject == Player.Instance.characterController) 
        {
            print("¹ÎÇõ¾Æ³ª½È¾îÇÏÁö¸»¾ÆÁÖ.......................................................................................................................................................................................................................................................................................................................................................................................................");
            Player.Instance.energy++;
            Destroy(gameObject);
        }

    }
}
