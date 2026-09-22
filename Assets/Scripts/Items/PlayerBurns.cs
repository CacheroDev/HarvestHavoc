using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBurns : MonoBehaviour, IFire
{
    [SerializeField] GameObject player;
    [SerializeField] bool burnEnabler;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        burnEnabler = true;
    }

    void Update()
    {
        
    }

    public void BurningPlayer()
    {
        if (burnEnabler)
        {
            burnEnabler = false;
            player.GetComponent<PlayerHP>().decreaseHP = true; 
            StartCoroutine(BurningSequence());
        }
    }

    IEnumerator BurningSequence()
    {
        yield return new WaitForSeconds(2);
        burnEnabler = true;
    }
}
