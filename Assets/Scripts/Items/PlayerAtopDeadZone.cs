using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtopDeadZone : MonoBehaviour, IDeadZone
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DeadPlayer()
    {
        Debug.Log("Player blinks, deact movement and jump, hp--, return to origPos");
    }

}
