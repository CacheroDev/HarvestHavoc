using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] public int playerHP;
    [SerializeField] public bool decreaseHP;
    [SerializeField] public bool updateHPUI;
    [SerializeField] bool readyToReset;
    [SerializeField] public bool activateResetButton;
    [SerializeField] public bool changeColor;
    [SerializeField] public bool gameIsOver;
    //[SerializeField] CapsuleCollider2D capsuleCol;

    void Start()
    {
        decreaseHP = false;
        updateHPUI = false;
        readyToReset = true;
        activateResetButton = false;
        changeColor = false;
        gameIsOver = false;
        //capsuleCol = GetComponent<CapsuleCollider2D>();
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
            readyToReset = false;
            //Debug.Log("0 life");
            gameObject.GetComponent<DisablePlayer>().fullDisable = true;
            activateResetButton = true;
            gameIsOver = true;
        }
    }

    void LoseALife()
    {
        //Debug.Log("Lose a life");
        if (playerHP > 0)
        {
            playerHP--; //Debug.Log("enough life");
        }
    }
}
