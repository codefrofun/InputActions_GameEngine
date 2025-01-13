using System;
using System.Collections.Generic;
using UnityEngine;

public class ActionInput : MonoBehaviour
{
    public static class Actioninput
    {
        public static Action InputJump;
    }

    public static event Action OnJumpStarted;
    public static event Action OnJumpPerformed;
    public static event Action OnJumpCanceled;
}