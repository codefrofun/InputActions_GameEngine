using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, PlayerInput.IGameInputActions
{
    public PlayerInput playerInput; 

    void Awake()
    {
        // Creating instance of player
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

    public void OnButtonConfirm(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Actioninput.ButtonConfirm?.Invoke(); // Starting input for button being pressed (should turn green)
        }

        if (context.performed)
        {
            Actioninput.ButtonConfirm?.Invoke(); // Input is being done (should stay green whil ebutton is being held)
        }

        if (context.canceled)
        {
            Actioninput.ButtonConfirm?.Invoke(); // Input is complete (should turn red once button is let go of)
        }
    }
}