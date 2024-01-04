using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
public class VisualizeGunRange : MonoSingleton<VisualizeGunRange>
{
    public void Visualize(float range, GameObject showRange, Transform viewModelTransform)
    {
        Instantiate(showRange, viewModelTransform.forward * range, viewModelTransform.transform.rotation);
        showRange.transform.localScale = new Vector3(0.05f,
            0.05f, range);
    }
}
