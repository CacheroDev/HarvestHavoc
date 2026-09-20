using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    [SerializeField] float forceMultiplier;
    [SerializeField] public bool isKnocked;
    [SerializeField] public string direction;

    PlayerMovement playerMovement;
    Rigidbody2D rb;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isKnocked)
        {
            isKnocked = false;
            playerMovement.enabled = false;
            if (direction == "left")
            {
                rb.velocity = new Vector2(-forceMultiplier, rb.velocity.y);
            }
            else if (direction == "right")
            {
                rb.velocity = new Vector2(forceMultiplier, rb.velocity.y);
            }
            else
            {

            }
            StartCoroutine(KnockbackSequence());
        }
    }

    IEnumerator KnockbackSequence()
    {
        yield return new WaitForSeconds(1);
        playerMovement.enabled = true;
    }
}
