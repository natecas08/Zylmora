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
    public float doubleJumpForceMultiplier = 1.5f;
    public LayerMask groundLayer;

    public float moveSpeed = 5.0f;

    private PlayerControls playerControls;
    private Rigidbody rb;
    private Vector2 moveInput;

    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);

        Vector2 moveVelocity = new Vector2(moveInput.x * moveSpeed, rb.velocity.y);
        rb.velocity = moveVelocity;
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            if (isGrounded)
            {
                rb.AddForce(Vector2.up * jumpForceMultiplier, ForceMode.Impulse);
                doubleJumpUsed = false;
            }
            else if (doubleJumpEnabled && !doubleJumpUsed)
            {
                rb.velocity = new Vector2(moveInput.x * moveSpeed, 0);
                rb.AddForce(Vector2.up * jumpForceMultiplier * doubleJumpForceMultiplier, ForceMode.Impulse);
                doubleJumpUsed = true;
            }
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

}
