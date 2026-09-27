using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReactFallenFruit : MonoBehaviour
{
    [SerializeField] GameObject fruit;
    //[SerializeField] GameObject player;
    //[SerializeField] SoundFX sfx;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            //sfx.PlaySFX(sfx.dropFruit);
            //player.GetComponent<Animator>().Play("ReactFallenFruit");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
