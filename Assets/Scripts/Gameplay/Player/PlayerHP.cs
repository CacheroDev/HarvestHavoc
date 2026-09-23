using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] public int playerHP;
    [SerializeField] public bool decreaseHP;
    [SerializeField] public bool updateHPUI;
    [SerializeField] bool readyToReset;
    [SerializeField] public bool reloadActiveScene;
    [SerializeField] public bool changeColor;

    void Start()
    {
        decreaseHP = false;
        updateHPUI = false;
        readyToReset = true;
        changeColor = false;
    }

    void Update()
    {
        if (decreaseHP)
        {
            decreaseHP = false;
            updateHPUI = true;
            changeColor = true;
            LoseALife();
        }
        if (playerHP < 1 && readyToReset)
        {
            Debug.Log("Reset stage");
            readyToReset = false;
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<PlayerJump>().enabled = false;
            reloadActiveScene = true;
            
        }
    }

    void LoseALife()
    {
        if (playerHP > 0)
        {
            playerHP--;
        }
    }
}
