using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlayer : MonoBehaviour
{
    [SerializeField] public bool disable;

    void Start()
    {
        disable = false;
    }

    void Update()
    {
        if (disable)
        {
            disable = false;
            StartCoroutine(DisableSequence());
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
}
