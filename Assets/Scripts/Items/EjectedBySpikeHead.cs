using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjectedBySpikeHead : MonoBehaviour, ISpikeHead
{
    [SerializeField] GameObject player;
    [SerializeField] bool tossPlayer;
    BoxCollider2D boxCol;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        boxCol = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }

    public void SpikeEjection()
    {
        Debug.Log("Spikehead collision");
        StartCoroutine(PlayerToss());
    }

    IEnumerator PlayerToss()
    {
        
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(7, player.GetComponent<Rigidbody2D>().velocity.y);
        Debug.Log("Pu talsik"); yield return new WaitForSeconds(1);
    }
}
