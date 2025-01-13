using UnityEngine;
using static ActionInput;

public class SquareEvent : MonoBehaviour
{
    public float jumpSquare = 12f; // Force of basketball, changes in inspector
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Giving ball ability to move
    }

    // Throw ball when you press space
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpSquare(); // Calling  method that moves the ball
        }
    }

    void JumpSquare()
    {
        // Throw upward
        Vector3 upwardForce = Vector3.up * jumpSquare;

        rb.AddForce(upwardForce, ForceMode.Impulse); // Adding forces for ball to move towards the net
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basket"))
        {
            Actioninput.InputJump?.Invoke(); // Calling / invoking the action manager action
        }
    }



    public static void TriggerJumpStarted()
    {
        OnJumpStarted?.Invoke();
    }

    public static void TriggerJumpPerformed()
    {
        OnJumpPerformed?.Invoke();
    }

    public static void TriggerJumpCanceled()
    {
        OnJumpCanceled?.Invoke();
    }
}
