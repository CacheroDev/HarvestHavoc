using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessAnimWithAttack : MonoBehaviour
{
    [SerializeField] PlayerMovement movement;
    [SerializeField] PlayerJump jump;
    [SerializeField] FeetCollision feetCol;
    //[SerializeField] ThrowStrawberry throwStrawberry;
    Animator anim;

    void Start()
    {
        movement = GetComponent<PlayerMovement>();
        jump = GetComponent<PlayerJump>();
        anim = GetComponent<Animator>();
        feetCol = GameObject.FindGameObjectWithTag("Feet").GetComponent<FeetCollision>();
        //throwStrawberry = GameObject.FindGameObjectWithTag("PrincessSpawner").GetComponent<ThrowStrawberry>();
    }

    void Update()
    {
        //Facing
        if (!movement.isFacingRight)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if (movement.isFacingRight)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        else
        {

        }

        //Animation

        if (!movement.enabled)
        {
            anim.Play("PrincessIdle");
        }
        else
        {
            //if (throwStrawberry.attack)
            //{
            //    anim.Play("Attack");
            //}
            //else 
            if (jump.isJumping || !feetCol.isGrounded)
            {
                anim.Play("PrincessJump");
            }
            else if (movement.isRunning)
            {
                anim.Play("PrincessRun");
            }
            else
            {
                anim.Play("PrincessIdle");
            }
        }
        
    }
}
