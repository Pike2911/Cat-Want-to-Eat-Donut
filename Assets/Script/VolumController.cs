using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumController : MonoBehaviour
{
    Slider volumSlider;

    void Start()
    {
        volumSlider = GetComponent<Slider>();
    }

    public void VolumChange()
    {
        AudioListener.volume = volumSlider.value;
    }
}
