using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForceMultiplier = 5.0f;
    private PlayerControls playerControls;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody>();
    }

    private void OnJump()
    {
        rb.AddForce(Vector2.up * jumpForceMultiplier, ForceMode.Impulse);
    }
}
