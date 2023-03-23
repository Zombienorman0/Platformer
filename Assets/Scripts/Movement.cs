using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    Rigidbody body;
    PlayerInput playerInput;
    Vector2 moveVector;
    public void OnJump(bool isPressed)
    {
            body.AddForce(8f * Vector2.up, ForceMode.Impulse);
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
    }
}
