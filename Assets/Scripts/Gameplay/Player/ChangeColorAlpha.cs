using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAlpha : MonoBehaviour
{
    [SerializeField] PlayerHP playerHP;
    SpriteRenderer spriteRen;
    //Color color;

    void Start()
    {
        spriteRen = GetComponent<SpriteRenderer>();
        playerHP = GetComponent<PlayerHP>();
        //color = GetComponent<SpriteRenderer>().color; Debug.Log(color);
    }

    void Update()
    {
        if (playerHP.changeColor)
        {
            playerHP.changeColor = false; Debug.Log("Change alpha");
            StartCoroutine(ColorSequence());
        }
    }

    IEnumerator ColorSequence()
    {
        for (int i=0; i<4; i++)
        {
            spriteRen.color = new Color(1, 1, 1, 0.4f);
            yield return new WaitForSeconds(0.25f);
            spriteRen.color = Color.white;
            yield return new WaitForSeconds(0.25f);
        }
    }
}
