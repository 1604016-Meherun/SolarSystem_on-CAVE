using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab_and_release : MonoBehaviour
{
    private bool isGrabbed = false;  // To track if the object is grabbed
    private Transform grabberHand;   // Reference to the hand grabbing the object
    private Vector3 originalPosition;  // To store the original position of the object

    public float returnSpeed = 5f;  // Speed at which the object returns
    void Start()
    {
        // Save the initial position when the game starts
        originalPosition = transform.position;
    }

    void Update()
    {
        if (isGrabbed && grabberHand != null)
    {
        transform.position = grabberHand.position;
    }
    // else if (!isGrabbed)
    // {
    //     // Smoothly move the object back to its original position
    //     transform.position = Vector3.MoveTowards(
    //         transform.position, originalPosition, returnSpeed * Time.deltaTime);
    // }
    }

    // Called when the user grabs the object
    public void OnGrab(Transform hand)
    {
        isGrabbed = true;
        grabberHand = hand;
    }

    // Called when the user releases the object
    public void OnRelease()
    {
        isGrabbed = false;
        grabberHand = null;

        // Reset the object's position to its original position
        transform.position = originalPosition;
    }
}
