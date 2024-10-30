using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public GameObject PlanetObject;       // Assign your planet in the Inspector
    public Vector3 RotationVector = new Vector3(0, 1, 0);  // Default rotation on the Y-axis
    public float rotationSpeed = 10f;     // Adjust the speed to make it slower

    // Update is called once per frame
    void Update()
    {
        // Adjust rotation speed and apply rotation
        float step = rotationSpeed * Time.deltaTime;

        // Rotate using Quaternion for smoother and safer rotations
        PlanetObject.transform.Rotate(RotationVector * step, Space.Self);
        Debug.Log("error is not here!");
    }
}
