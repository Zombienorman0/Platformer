using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    Rigidbody body;
    PlayerInput playerInput;
    Vector2 moveVector;
    [SerializeField] InputAction moveLeft;
    [SerializeField] InputAction moveRight;
    [SerializeField] InputAction Jump;
    // Start is called before the first frame update
    void Start()
    {
       
        body = GetComponent<Rigidbody>();
        moveVector = Vector2.zero;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.AddForce(4.5f * moveVector * Vector2.right);

    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.action.WasPerformedThisFrame())
        {
            body.AddForce(8f * Vector2.up, ForceMode.Impulse);
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
    }
}
