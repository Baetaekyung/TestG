using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class UI_Test_Gay : MonoSingleton<UI_Test_Gay>
{

    [Header("Fuck")]
    public Text energy;
    public Text energy2;
    public void UpdateEnergy()
    {
        energy.text = "Energy : " + Player.Instance.energy;
        energy2.text = Player.Instance.energy + "/" + Player.Instance.energyMax;
    }
}
