using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumController : MonoBehaviour
{
    Slider volumSlider;
    // Start is called before the first frame update
    void Start()
    {
        volumSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    public void VolumChange()
    {
        AudioListener.volume = volumSlider.value;
    }
}
