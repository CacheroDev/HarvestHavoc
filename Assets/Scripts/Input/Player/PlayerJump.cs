using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] KeyCode jump;
    [SerializeField] float jumpForce;
    [SerializeField] FeetCollision feetCol;
    [SerializeField] public bool isJumping;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(jump) && feetCol.isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
