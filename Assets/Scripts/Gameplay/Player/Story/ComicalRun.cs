using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicalRun : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
}
