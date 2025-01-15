using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Actioninput;

public class CapsuleEvent : MonoBehaviour
{
    public float slideCapsule = 5f; // Force of capsule
    public Rigidbody rb;
    private bool isSliding = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Ability to roll
    }

    void SlideCapsule()
    {
        if (!isSliding)
        {
            // Throw towrads the right
            Vector3 rightForce = Vector3.right * slideCapsule;

            rb.AddForce(rightForce, ForceMode.Impulse); // Adding force so it moves
            isSliding = true;
            if (isSliding)
            {
                rb.velocity = Vector3.zero;
                isSliding = false;
                Debug.Log("Sliding is cancelled.");
            }
        }
    }

    void OnEnable()
    {
        // Subscribe to the action
        Actioninput.SlideTheCapsule += SlideCapsule;
        //Actioninput.CancelSlideTheCapsule += CancelSlideCapsule;
    }

    void OnDisable()
    {
        // Unsubscribe from the event
        Actioninput.SlideTheCapsule -= SlideCapsule;
        //Actioninput.CancelSlideTheCapsule -= CancelSlideCapsule;
    }
}
