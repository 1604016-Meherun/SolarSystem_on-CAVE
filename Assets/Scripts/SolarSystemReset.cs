// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SolarSystemReset : MonoBehaviour
// {
//     [System.Serializable]
//     public class Planet
//     {
//         public Transform planetTransform; // Reference to the planet's Transform
//         public Vector3 initialPosition;   // Initial position of the planet
//         public Vector3 initialRotation;   // Initial rotation (Euler angles)
//         public Vector3 initialScale;      // Initial scale of the planet
//     }

//     public Planet[] planets; // Array to store all planets

//     void Start()
//     {
//         // Store the initial transform values for each planet
//         foreach (var planet in planets)
//         {
//             planet.initialPosition = planet.planetTransform.position;
//             planet.initialRotation = planet.planetTransform.rotation.eulerAngles;
//             planet.initialScale = planet.planetTransform.localScale;
//         }
//     }

//     public void ResetSolarSystem()
//     {
//         // Reset position, rotation, and scale of each planet
//         foreach (var planet in planets)
//         {
//             planet.planetTransform.position = planet.initialPosition;
//             planet.planetTransform.rotation = Quaternion.Euler(planet.initialRotation);
//             planet.planetTransform.localScale = planet.initialScale;
//         }

//         Debug.Log("Solar system reset to initial state!");
//     }
// }



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SolarSystemReset : MonoBehaviour
{
    public void ResetSolarSystem()
    {
        // Reload the scene by name
        SceneManager.LoadScene("SampleScene");
    }

}