using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] KeyCode jump;
    [SerializeField] float jumpForce;
    [SerializeField] FeetCollision feetCol;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jump) && feetCol.isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
