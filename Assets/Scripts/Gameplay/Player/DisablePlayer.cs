using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlayer : MonoBehaviour
{
    [SerializeField] public bool disable;
    [SerializeField] public bool fullDisable;

    void Start()
    {
        disable = false;
        fullDisable = false;
    }

    void Update()
    {
        if (disable)
        {
            disable = false;
            StartCoroutine(DisableSequence());
        }
        if (fullDisable)
        {
            fullDisable = false;
            StartCoroutine(FullDisableSequence());
        }

    }

    IEnumerator DisableSequence()
    {
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerJump>().enabled = false;
        yield return new WaitForSeconds(2);
        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<PlayerJump>().enabled = true;
    }

    IEnumerator FullDisableSequence()
    {
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerJump>().enabled = false;
        yield return new WaitForSeconds(0);
    }
}
