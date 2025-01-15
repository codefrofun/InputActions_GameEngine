using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, PlayerInput.IGameInputActions
{
    public PlayerInput playerInput;
    public CancelEvent cancelEvent;  // Reference to the CancelEvent script

    void Awake()
    {
        // Creating instance of player
        playerInput = new PlayerInput();
        playerInput.GameInput.Enable();

        playerInput.GameInput.SetCallbacks(this); // Listener for actions and events
        cancelEvent = GetComponent<CancelEvent>();  // Get the CancelEvent component
    }

    void Start()
    {
        if (cancelEvent == null)
        {
            Debug.LogError("CancelEvent script is not attached to this GameObject.");
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Actioninput.InputJump?.Invoke(); // Starting input for jumping
        }

        if (context.performed)
        {
            Actioninput.InputJump?.Invoke(); // Input is being done
        }

        if (context.canceled)
        {
            Actioninput.InputJump?.Invoke(); // Input is complete
        }
    }

    public void OnSlide(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Actioninput.SlideTheCapsule?.Invoke(); // Starting input for sliding
        }

        if (context.performed)
        {
            Actioninput.SlideTheCapsule?.Invoke(); // Input is being done
        }

        if (context.canceled)
        {
            Actioninput.SlideTheCapsule?.Invoke(); // Input is complete
        }
    }

    public void OnChangeColour(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Actioninput.SphereColourChange?.Invoke(); // Starting input for colour changing
        }

        if (context.performed)
        {
            Actioninput.SphereColourChange?.Invoke(); // Input is being done
        }

        if (context.canceled)
        {
            Actioninput.SphereColourChange?.Invoke(); // Input is complete
        }
    }

    public void OnButtonConfirm(InputAction.CallbackContext context)
    {
        if (cancelEvent == null)
        {
            Debug.LogError("CancelEvent is not initialized correctly.");
            return;  // Avoid calling methods if cancelEvent is null
        }

        if (context.started)
        {
            cancelEvent.ChangeColorGreen();
        }

        if (context.performed)
        {
            // 
        }

        if (context.canceled)
        {
            cancelEvent.ChangeColourRed();
        }
    }
}