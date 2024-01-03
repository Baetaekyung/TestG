using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColorSetting : MonoBehaviour
{
    [SerializeField] private int itsEnergy;
    private Color wallColor;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if(itsEnergy > Player.Instance.energy)
        {
            float energyDiff = itsEnergy - Player.Instance.energy;
            if(energyDiff >= 1 && energyDiff < 2)
            {
                wallColor = Color.yellow;
            }
            else if(energyDiff >= 2 && energyDiff < 3)
            {
                wallColor = Color.red;
            }
            else if(energyDiff >= 3)
            {
                wallColor = Color.black;
            }
        }
        else
        {
            wallColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        }
        meshRenderer.material.color = wallColor;
    }
}
