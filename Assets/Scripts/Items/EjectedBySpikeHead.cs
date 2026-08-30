using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectedBySpikeHead : MonoBehaviour, ISpikeHead
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SpikeEjection()
    {
        Debug.Log("Toss player. Deactivate player movement and jump for 2s");
    }
}
