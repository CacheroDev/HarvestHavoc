using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CenterTexter : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] TextMeshProUGUI centerText;
    [SerializeField] GameObject centerBoxHolder;
    [SerializeField] GameObject player;


    void Start()
    {
        door = GameObject.FindGameObjectWithTag("Door");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (door.GetComponent<DoorOpener>().findTheKey)
        {
            door.GetComponent<DoorOpener>().findTheKey = false;
            StartCoroutine(PromptForTheKey());
        }
        if (player.GetComponent<PlayerHP>().gameIsOver)
        {
            player.GetComponent<PlayerHP>().gameIsOver = false;
            StartCoroutine(PromptForGameOver());
        }
    }

    IEnumerator PromptForTheKey()
    {
        centerBoxHolder.SetActive(true);
        centerText.text = "Find the key";
        yield return new WaitForSeconds(2);
        centerBoxHolder.SetActive(false);
        centerText.text = "";
    }
    IEnumerator PromptForGameOver()
    {
        centerBoxHolder.SetActive(true);
        centerText.text = "Game Over";
        yield return new WaitForSeconds(2);
    }
}
