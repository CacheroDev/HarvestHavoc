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
    [SerializeField] GameObject deadzone;

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
        if (deadzone.GetComponent<DeadZone>().prompt)
        {
            deadzone.GetComponent<DeadZone>().prompt = false;
            StartCoroutine(PromptForDeadzone());
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

    IEnumerator PromptForDeadzone()
    {
        centerBoxHolder.SetActive(true);
        centerText.text = "Deadzone";
        yield return new WaitForSeconds(2);
        centerBoxHolder.SetActive(false);
        centerText.text = "";
    }
}
