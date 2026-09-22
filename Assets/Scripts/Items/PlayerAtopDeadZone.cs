using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtopDeadZone : MonoBehaviour, IDeadZone
{
    [SerializeField] GameObject player;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
    }

    public void DeadPlayer()
    {
        player.GetComponent<DisablePlayer>().disable = true;
        StartCoroutine(DeadzoneSequence());
    }

    IEnumerator DeadzoneSequence()
    {
        yield return new WaitForSeconds(2);
        player.transform.position = Vector2.zero;
    }
}
