using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class UI_Test_Gay : MonoSingleton<UI_Test_Gay>
{

    [Header("Fuck")]
    public TextMeshProUGUI energy;
    public TextMeshProUGUI energy2;
    public void UpdateEnergy()
    {
        energy.text = "Energy : " + Player.Instance.energy;
        energy2.text = "Max Energy : " + Player.Instance.energyMax;
    }
}
