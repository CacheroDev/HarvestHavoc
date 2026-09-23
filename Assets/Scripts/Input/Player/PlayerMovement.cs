using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float horizontal;
    [SerializeField] float speed;
    [SerializeField] public bool isFacingRight;
    [SerializeField] public bool isRunning;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isFacingRight = true;
        isRunning = false;
    }


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (horizontal > 0)
        {
            isFacingRight = true;
            isRunning = true;
        }
        else if(horizontal < 0)
        {
            isFacingRight = false;
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
    }
}
