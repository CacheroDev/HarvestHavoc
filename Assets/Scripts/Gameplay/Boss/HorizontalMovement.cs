using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x > 7.1f)
        {
            transform.Translate(speed * Time.deltaTime * Vector2.left);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
