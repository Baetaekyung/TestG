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
        wallColor = meshRenderer.material.color;
    }

    private void Start()
    {
        switch (itsEnergy)
        {
            case 0:
                wallColor = Color.white;
                break;
            case 1:
                wallColor = Color.green;
                break;
            case 2:
                wallColor = Color.yellow;
                break;
            case 3:
                wallColor = Color.red;
                break;
            default:
                return;
        }
        meshRenderer.material.color = wallColor;
    }
}
