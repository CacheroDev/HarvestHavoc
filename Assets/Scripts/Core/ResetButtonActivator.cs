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
        if (player.GetComponent<PlayerHP>().activateResetButton)
        {
            player.GetComponent<PlayerHP>().activateResetButton = false;
            resetButton.SetActive(true);
        }
    }
}
