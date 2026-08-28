using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] KeyCode jump;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
