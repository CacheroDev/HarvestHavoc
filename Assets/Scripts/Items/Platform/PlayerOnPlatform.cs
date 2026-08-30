using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnPlatform : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.parent = transform;
            //Debug.Log("Platform set to parent");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.parent = null;
            //Debug.Log("Player parent set to null");
        }
    }
}
