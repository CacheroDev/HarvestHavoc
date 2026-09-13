using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionArea : MonoBehaviour
{
    [SerializeField] float forceMultiplier;
    PlayerMovement playerMovement;
    Rigidbody2D playerRb;

    void Start()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playerRb = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collided");
        StartCoroutine(CollisionSequence());
    }

    IEnumerator CollisionSequence()
    {
        playerMovement.enabled = false;
        playerRb.velocity = new Vector2(1 * forceMultiplier, playerRb.velocity.y);
        yield return new WaitForSeconds(1);
        playerMovement.enabled = true;
    }
}
