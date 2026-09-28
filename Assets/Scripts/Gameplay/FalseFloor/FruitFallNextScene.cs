
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitFallNextScene : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
