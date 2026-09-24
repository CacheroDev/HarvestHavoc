using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectedBySpikeHead : MonoBehaviour, ISpikeHead
{
    [SerializeField] bool collisionEnabler;
    [SerializeField] SoundFX sfx;
    [SerializeField] GameObject player;
    BoxCollider2D boxCol;

    void Start()
    {
        collisionEnabler = true;
        sfx = GameObject.FindGameObjectWithTag("SFX").GetComponent<SoundFX>();
        player = GameObject.FindGameObjectWithTag("Player");
        boxCol = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }

    public void SpikeEjection()
    {
        //Debug.Log("Spikehead collision");
        if (collisionEnabler)
        {
            collisionEnabler = false;
            sfx.PlaySFX(sfx.fire);
            player.GetComponent<Knockback>().isKnocked = true;
            player.GetComponent<PlayerHP>().decreaseHP = true;
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
        yield return new WaitForSeconds(2);
        boxCol.enabled = true;
        collisionEnabler = true;
    }
}
