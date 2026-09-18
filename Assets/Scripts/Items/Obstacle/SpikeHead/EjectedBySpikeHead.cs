using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectedBySpikeHead : MonoBehaviour, ISpikeHead
{
    [SerializeField] bool collisionEnabler;
    //[SerializeField] public bool isKnocked;
    [SerializeField] GameObject player;
    BoxCollider2D boxCol;

    void Start()
    {
        collisionEnabler = true;
        player = GameObject.FindGameObjectWithTag("Player");
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
            player.GetComponent<Knockback>().isKnocked = true;
            if (transform.position.x - player.transform.position.x > 0)
            {
                player.GetComponent<Knockback>().direction = "left";
            }
            else
            {
                player.GetComponent<Knockback>().direction = "right";
            }
        StartCoroutine(CollisionSequence());
        }    
    }


    IEnumerator CollisionSequence()
    {
        boxCol.enabled = false;
        yield return new WaitForSeconds(1);
        boxCol.enabled = true;
        collisionEnabler = true;
    }
}
