using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelEvent : MonoBehaviour
{
    public Renderer targetRenderer;
    private bool buttonPressed = false;

    
    void ChangeColorGreen()
    {
        if(buttonPressed == true)
        {
            // Changes the RGB colour values
            Color newColor = new Color(255, 48, 255);
            //renders new material
            targetRenderer.material.color = newColor;
        }
    }

    void ChangeColourRed()
    {
        if (buttonPressed == false)
        {
            // Changes the RGB colour values
            Color newColor = new Color(200, 0, 0);
            //renders new material
            targetRenderer.material.color = newColor;
        }
    }

    void OnEnable()
    {
        // Subscribe to the action
        Actioninput.ButtonConfirm += ChangeColorGreen;
        Actioninput.ButtonConfirm += ChangeColourRed;
    }

    void OnDisable()
    {
        // Unsubscribe from the event
        Actioninput.ButtonConfirm -= ChangeColorGreen;
        Actioninput.ButtonConfirm -= ChangeColourRed;
    }
}
