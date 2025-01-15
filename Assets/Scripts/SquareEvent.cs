using UnityEngine;
using static Actioninput;

public class SquareEvent : MonoBehaviour
{
    public float jumpSquare = 1.5f; 
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Ability to jump
    }

    void JumpSquare()
    {
        // Throw upward
        Vector3 upwardForce = Vector3.up * jumpSquare;

        rb.AddForce(upwardForce, ForceMode.Impulse); 
    }

    void OnEnable()
    {
        // Subscribe to the action
        Actioninput.InputJump += JumpSquare;
    }

    void OnDisable()
    {
        // Unsubscribe from the event
        Actioninput.InputJump -= JumpSquare;
    }
}
