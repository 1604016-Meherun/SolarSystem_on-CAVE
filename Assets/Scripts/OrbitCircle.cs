// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// [RequireComponent(typeof(LineRenderer))]
// public class OrbitCircle : MonoBehaviour
// {
//     public int segments = 100;  // Number of segments for the circle (smoothness)
//     public float radius = 30f;  // Orbit radius
//     private LineRenderer lineRenderer;

//     void Start()
//     {
//         lineRenderer = GetComponent<LineRenderer>();
//         lineRenderer.positionCount = segments + 1;  // Add 1 to close the loop
//         lineRenderer.useWorldSpace = true;
//         DrawOrbit();
//     }

//     void DrawOrbit()
//     {
//         float angle = 0f;
//         for (int i = 0; i < segments + 1; i++)
//         {
//             float x = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
//             float z = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
//             lineRenderer.SetPosition(i, new Vector3(x, 0, z));
//             angle += 360f / segments;
//         }
//     }
// }

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(LineRenderer))]
public class OrbitCircle : MonoBehaviour
{
    public int segments = 100;    // Number of points in the ellipse
    public float xRadius = 5f;    // Horizontal radius
    public float yRadius = 3f;    // Vertical radius

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segments + 1;  // Close the loop
        lineRenderer.useWorldSpace = false;

        DrawEllipse();
    }

    void DrawEllipse()
    {
        float angleStep = 360f / segments;  // Angle step between points

        for (int i = 0; i <= segments; i++)
        {
            float angle = Mathf.Deg2Rad * (i * angleStep);  // Convert to radians
            float x = Mathf.Cos(angle) * xRadius;  // X position on ellipse
            float y = Mathf.Sin(angle) * yRadius;  // Y position on ellipse

            lineRenderer.SetPosition(i, new Vector3(x, y, 0f));  // Set point position
        }
    }
}
