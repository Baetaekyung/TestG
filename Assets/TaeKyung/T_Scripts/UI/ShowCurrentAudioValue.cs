using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowCurrentAudioValue : MonoBehaviour
{
    [SerializeField] private Slider audioSlider;
    [SerializeField] private TextMeshProUGUI audioValueText;
    
    public void ValueChanged()
    {
        audioValueText.text = audioSlider.value.ToString() + "%";
    }
}
