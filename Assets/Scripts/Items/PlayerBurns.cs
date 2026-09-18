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
        Debug.Log("Player on fire. Player blinks. hp--");
        if (burnEnabler)
        {
            burnEnabler = false;
            StartCoroutine(BurningSequence());
        }
    }

    IEnumerator BurningSequence()
    {
        Color playerColor = player.GetComponent<SpriteRenderer>().color;
        playerColor = new Color(playerColor.r, playerColor.b, playerColor.g, 0.2f);
            

        yield return new WaitForSeconds(1);
    }
}
