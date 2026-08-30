using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandOnKey : MonoBehaviour, IKey
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void KeyOnHand()
    {
        Debug.Log("Key blinks for 2s. Key on UI highlighted. Bool to open door set to true.");
    }
}
