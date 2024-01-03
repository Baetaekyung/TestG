using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class VignettControl : MonoBehaviour
{
    [SerializeField] private Volume volume;
    private Vignette vignette;
    private Toggle toggle;

    private void Awake()
    {
        toggle = GetComponent<Toggle>();
        volume.profile.TryGet(out vignette);
    }

    private void Start()
    {
        vignette.active = toggle.isOn;
    }

    public void ChangeVignetteValue()
    {
        if (toggle.isOn)
        {
            vignette.active = true;
        }
        else
        {
            vignette.active = false;
        }
    }
}
