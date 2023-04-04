using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D body;
    PlayerInput playerInput;
    Vector2 moveVector;
    [SerializeField] InputAction moveLeft;
    [SerializeField] InputAction moveRight;
    [SerializeField] InputAction Jump;
    // Start is called before the first frame update
    void Start()
    {
       
        body = GetComponent<Rigidbody2D>();
        moveVector = Vector2.zero;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.AddForce(4.5f * moveVector * Vector2.right);
        OnJump(Jump);
        
    }

    public void OnJump(InputAction context)
    {
        if (context.WasPerformedThisFrame())
        {
            body.AddForce(12f * Vector2.up, ForceMode2D.Impulse);
        }
    }
    public void OnMove(InputAction context)
    {
        moveVector = context.ReadValue<Vector2>();
    }

}
