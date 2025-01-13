using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, PlayerInput.IGameInputActions
{
    public PlayerInput playerInput; 

    void Awake()
    {
        // CReating instance of player
        playerInput = new PlayerInput();
        playerInput.GameInput.Enable();

        playerInput.GameInput.SetCallbacks(this); // Listener for actions and events
    }

    void Start()
    {
        // Leave Empty
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
}