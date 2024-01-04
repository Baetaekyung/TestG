using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class VisualizeGunRange : MonoSingleton<VisualizeGunRange>
{
    public void Visualize(float range, GameObject showRange, Transform viewModelTransform)
    {
        Instantiate(showRange, viewModelTransform.position - new Vector3(viewModelTransform.position.x, 0,
            viewModelTransform.position.z) * 0.5f, viewModelTransform.transform.rotation);
        showRange.transform.localScale = new Vector3(0.05f,
            0.05f, range);
    }
}
