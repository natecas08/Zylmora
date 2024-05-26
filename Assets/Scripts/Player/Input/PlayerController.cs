using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public bool doubleJumpEnabled = false;
    private bool doubleJumpUsed = false;

    public float jumpForceMultiplier = 5.0f;
    public float groundCheckDistance = 0.2f;
    public LayerMask groundLayer;

    public float moveSpeed = 1.0f;

    private PlayerControls playerControls;
    private Rigidbody rb;

    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);
        
    }

    private void OnJump()
    {
        if(isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForceMultiplier, ForceMode.Impulse);
            doubleJumpUsed = false;
        }
        else if(doubleJumpEnabled && !doubleJumpUsed)
        {
            rb.AddForce(Vector2.up * jumpForceMultiplier, ForceMode.Impulse);
            doubleJumpUsed = true;
        }
    }

    private void OnMove(InputValue inputValue)
    {
        rb.velocity = inputValue.Get<Vector2>() * moveSpeed;

    }
}
