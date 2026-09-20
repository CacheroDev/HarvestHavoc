using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeHeadCollisionHandler : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<IUpperLimit>().UpperLimitEffect();
    }
}
