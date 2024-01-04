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
        currentEnergy.text = "���� ������ : " + Player.Instance.energy;
        maxEnergy.text = "�ִ� ������ : " + maxE;
    }

    private void Update()
    {
        currentEnergy.text = "���� ������ : " + Player.Instance.energy;
        maxEnergy.text = "�ִ� ������ : " + maxE; 
    }
}
