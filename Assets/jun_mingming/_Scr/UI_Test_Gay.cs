using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class UI_Test_Gay : MonoSingleton<UI_Test_Gay>
{
    public Text t1;
    public Text t2;
    public Text t3;

    [Header("Fuck")]
    public Text energy;
    public Text energy2;
    public void UpdateEnergy()
    {
        energy.text = "Energy : " + Player.Instance.energy;
        energy2.text = Player.Instance.energy + "/" + Player.Instance.energyMax;
    }
}
