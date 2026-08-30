using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<IDoor>()?.OpenDoor();
        collision.gameObject.GetComponent<IKey>()?.KeyOnHand();
        collision.gameObject.GetComponent<IFire>()?.BurningPlayer();
        collision.gameObject.GetComponent<IStrawberry>()?.AddStrawberry();
        collision.gameObject.GetComponent<ISpikeHead>()?.SpikeEjection();
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    collision.gameObject.GetComponent<IDeadZone>()?.PlayerDead();
    //}
}
