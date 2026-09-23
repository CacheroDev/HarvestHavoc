using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonActivator : MonoBehaviour
{
    [SerializeField] GameObject resetButton;
    [SerializeField] GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        if (player.GetComponent<PlayerHP>().reloadActiveScene)
        {
            player.GetComponent<PlayerHP>().reloadActiveScene = false;
            //player.GetComponent<PlayerMovement>().enabled = false;
            //player.GetComponent<PlayerJump>().enabled = false;
            resetButton.SetActive(true);
        }
    }
}
