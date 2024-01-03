using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ControlPostProcessing : MonoBehaviour
{
    [SerializeField] private Volume volume;
    private Bloom bloom;
    private Vignette vignette;

    private void Awake()
    {
        volume.profile.TryGet(out bloom);
        volume.profile.TryGet(out vignette);
    }

    public void ToggleBloom(bool b)
    {
        if (b)
        {
            bloom.active = true;
        }
        else
        {
            bloom.active = false;
        }
    }

    public void ToggleVignette()
    {
        vignette.active = true; 
    }
}
