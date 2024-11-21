using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeSlider_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider sizeSlider; // Assign this in the Inspector
    public Transform solarSystem; // Parent object containing all planets
    void Start()
    {
       // Optional: Initialize the slider to a default value, e.g., 1 (normal speed)
        sizeSlider.value = 6f;
        // Set initial size
        AdjustSize(6f);
        // Subscribe to slider's value change
        sizeSlider.onValueChanged.AddListener(AdjustSize); 
    }

    // Update is called once per frame
    public void AdjustSize(float value)
    {
        // Scale the entire solar system based on the slider value
        solarSystem.localScale = (Vector3.one * sizeSlider.value)/100;
    }
}