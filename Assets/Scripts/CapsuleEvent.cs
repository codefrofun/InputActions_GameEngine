using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Actioninput;

public class CapsuleEvent : MonoBehaviour
{
    public float slideCapsule = 5f; // Force of capsule
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Ability to roll
    }

    void SlideCapsule()
    {
        // Throw towrads the right
        Vector3 rightForce = Vector3.right * slideCapsule;

        rb.AddForce(rightForce, ForceMode.Impulse); // Adding force so it moves
    }

    void OnEnable()
    {
        // Subscribe to the action
        Actioninput.SlideTheCapsule += SlideCapsule;
    }

    void OnDisable()
    {
        // Unsubscribe from the event
        Actioninput.SlideTheCapsule -= SlideCapsule;
    }
}
