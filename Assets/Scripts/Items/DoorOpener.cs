using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour, IDoor
{
    [SerializeField] GameObject player;
    [SerializeField] public bool keyInHand;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        
    }

    public void OpenDoor()
    {
        if (keyInHand)
        {
            Debug.Log("Door opens, proceed to next stage");
        }
        else
        {
            Debug.Log("Find key");
        }
        
    }
}
