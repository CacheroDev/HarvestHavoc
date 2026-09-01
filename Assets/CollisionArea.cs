using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionArea : MonoBehaviour
{
    [SerializeField] float forceMultiplier;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided");
        collision.gameObject.GetComponent<Rigidbody2D>().velocity =
            new Vector2(1 * forceMultiplier, collision.gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
}
