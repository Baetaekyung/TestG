using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class BloomControl : MonoBehaviour
{
    [SerializeField] private Volume volume;
    private Toggle toggle;
    private Bloom bloom;

    private void Awake()
    {
        toggle = GetComponent<Toggle>();
        volume.profile.TryGet(out bloom);
    }

    private void Start()
    {
        bloom.active = toggle.isOn;
    }

    public void ChangeBloomValue()
    {
        if (toggle.isOn)
        {
            bloom.active = true;
        }
        else
        {
            bloom.active = false;
        }
    }
}
