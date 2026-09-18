using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerLimitCollider : MonoBehaviour
{
    BoxCollider2D boxCol;

    void Start()
    {
        boxCol = GetComponent<BoxCollider2D>();
        boxCol.enabled = true;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            boxCol.enabled = false;
            collision.gameObject.GetComponent<SpikeVerticalMovement>().lowerLimit = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            boxCol.enabled = true;
        }
    }
}
