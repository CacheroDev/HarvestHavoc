using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float limit;
    [SerializeField] bool move;
    float origPos;

    void Start()
    {
        origPos = transform.position.y;
    }

    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        if (origPos + limit > transform.position.y && !move)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
        else if (origPos - limit < transform.position.y && move)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        else
        {
            move = !move;
        }
    }
}
