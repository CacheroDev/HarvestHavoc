using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectedBySpikeHead : MonoBehaviour, ISpikeHead
{
    [SerializeField] GameObject player;
    [SerializeField] bool collisionEnabler;
    [SerializeField] float forceMultiplier;
    BoxCollider2D boxCol;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        collisionEnabler = true;
        boxCol = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }

    public void SpikeEjection()
    {
        Debug.Log("Spikehead collision");
        if (collisionEnabler)
        {
            collisionEnabler = false;
            StartCoroutine(CollisionSequence());
        }    
    }


    IEnumerator CollisionSequence()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        boxCol.enabled = false;

        if (player.transform.position.x - transform.position.x > 0)
        {
            //Toss player to the right
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(forceMultiplier, player.GetComponent<Rigidbody2D>().velocity.y); 
        }
        else
        {
            //Toss player to the left
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(-forceMultiplier, player.GetComponent<Rigidbody2D>().velocity.y); 
        }

        yield return new WaitForSeconds(1);

        player.GetComponent<PlayerMovement>().enabled = true;
        boxCol.enabled = true;
        collisionEnabler = true;
    }
}
