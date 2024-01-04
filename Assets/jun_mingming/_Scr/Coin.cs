using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void Interact()
    {
        Player.Instance.AddCoin(1);
    }
}
