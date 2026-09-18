using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperLimitCollider : MonoBehaviour
{
    [SerializeField] GameObject spikeHead;
    BoxCollider2D boxCol;

    void Start()
    {
        spikeHead = GameObject.FindGameObjectWithTag("Obstacle");
        boxCol = GetComponent<BoxCollider2D>();
        boxCol.enabled = true;
    }

    void Update()
    {
        //if (spikeHead.GetComponent<SpikeVerticalMovement>().enableUpperBoxCol)
        //{
        //    boxCol.enabled = true;
        //}
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            boxCol.enabled = false; Debug.Log("Box col 2d disabled");
            collision.gameObject.GetComponent<SpikeVerticalMovement>().upperLimit = true;
        }
    }
}
