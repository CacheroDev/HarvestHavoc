using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushback : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("On fire");
        if (collision.gameObject.tag == "Player")
        {
            if (collision.transform.position.x - transform.position.x < 0)
            {
                collision.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 600);
            }
            else
            {
                collision.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 600);
            }
        }
    }
}
