using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateHP : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] GameObject player;

    void Start()
    {
        hpText = GetComponent<TextMeshProUGUI>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player.GetComponent<PlayerHP>().updateHPUI)
        {
            player.GetComponent<PlayerHP>().updateHPUI = false;
            hpText.text = $"HP: {player.GetComponent<PlayerHP>().playerHP}";
        }
    }
}
