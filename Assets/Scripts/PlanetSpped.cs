using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetSpped : MonoBehaviour
{
    public Slider speedSlider; // Assign this in the Inspector
    public PlanetRotation[] planets; // Array to hold references to each planet

    void Start()
    {
        // Optional: Initialize the slider to a default value, e.g., 1 (normal speed)
        speedSlider.value = 1f;
        // Set initial rotation speed
        AdjustRotationSpeed(1f);
        // Subscribe to slider's value change
        speedSlider.onValueChanged.AddListener(AdjustRotationSpeed);
    }


    // Method to adjust rotation speed
    public void AdjustRotationSpeed(float value)
    {
        foreach (PlanetRotation planet in planets)
        {
            planet.SetGlobalSpeedMultiplier(speedSlider.value);
        }
    }
}
