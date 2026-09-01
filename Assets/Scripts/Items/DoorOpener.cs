using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpener : MonoBehaviour, IDoor
{
    [SerializeField] GameObject player;
    [SerializeField] public bool keyInHand;
    [SerializeField] float duration;
    Animator anim;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void OpenDoor()
    {
        if (keyInHand)
        {
            Debug.Log("Door opens, proceed to next stage");
            StartCoroutine(DoorOpensToNextScene());
        }
        else
        {
            Debug.Log("Find key");
        }    
    }

    IEnumerator DoorOpensToNextScene()
    {
        yield return new WaitForSeconds(duration);
        anim.Play("DoorOpens");            //Animate door
                                           //Play door opens sfx 
                                           //Proceed to next scene
        yield return new WaitForSeconds(duration);
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
