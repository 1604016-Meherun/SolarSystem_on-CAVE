using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetInfoInteraction : MonoBehaviour
{
    public GameObject infoPanel;  // Assign the corresponding info panel in the Inspector
    private bool isPanelActive = false;

    // This method will be called when a wand button is pressed or released
    public void MyWandButtonReaction(int iButton, bool iPressed)
    {
        // Check if Button 2 is pressed
        if (iButton == 2 && iPressed == true)
        {
            // Toggle the info panel's visibility
            isPanelActive = !isPanelActive;
            infoPanel.SetActive(isPanelActive);
        }
    }
}
