using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour, IDeadZone
{
    [SerializeField] GameObject player;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
    }

    public void DeadZoneEffect()
    {
        player.GetComponent<DisablePlayer>().disable = true;
        //deadzone prompt
        player.GetComponent<PlayerHP>().decreaseHP = true;
        StartCoroutine(DeadzoneSequence());
    }

    IEnumerator DeadzoneSequence()
    {
        yield return new WaitForSeconds(2);
        player.transform.position = Vector2.zero;
    }
}
