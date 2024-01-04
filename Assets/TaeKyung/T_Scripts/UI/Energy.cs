using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    public TextMeshProUGUI currentEnergy;
    public TextMeshProUGUI maxEnergy;

    private float maxE;

    private void Start()
    {
        maxE = Player.Instance.energyMax;
        currentEnergy.text = "현재 에너지 : " + Player.Instance.energy;
        maxEnergy.text = "최대 에너지 : " + maxE;
    }

    private void Update()
    {
        currentEnergy.text = "현재 에너지 : " + Player.Instance.energy;
        maxEnergy.text = "최대 에너지 : " + maxE; 
    }
}
