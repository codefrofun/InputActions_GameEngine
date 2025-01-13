using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, PlayerInput.IGameInputActions
{
    public PlayerInput playerInput;

    void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.GameInput.Enable();

        playerInput.GameInput.SetCallbacks(this);
    }

    void Start()
    {

    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            ActionInput.TriggerJumpStarted();
        }

        if (context.performed)
        {
            ActionInput.TriggerJumpPerformed();
        }

        if (context.canceled)
        {
            ActionInput.TriggerJumpPerformed();
        }
    }
}