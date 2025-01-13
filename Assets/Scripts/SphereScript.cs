using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public Renderer targetRenderer;


    void ChangeColor()
    {
        // Changes the RGB colour values
        Color newColor = new Color(Random.value, Random.value, Random.value);
        //renders new material
        targetRenderer.material.color = newColor;
    }

    void OnEnable()
    {
        // Subscribe to the action
        Actioninput.SphereColourChange += ChangeColor;
    }

    void OnDisable()
    {
        // Unsubscribe from the event
        Actioninput.SphereColourChange -= ChangeColor;
    }
}
