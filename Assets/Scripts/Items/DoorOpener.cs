using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DoorOpener : MonoBehaviour, IDoor
{
    [SerializeField] public bool keyInHand;
    [SerializeField] float duration;
    [SerializeField] public bool findTheKey;
    [SerializeField] SoundFX sfx;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void OpenDoor()
    {
        if (keyInHand)
        {
            //Debug.Log("Door opens, proceed to next stage");
            StartCoroutine(DoorOpensToNextScene());
        }
        else
        {
            findTheKey = true;
            sfx.PlaySFX(sfx.oneShortLowStep);
            //Debug.Log("Find key");
        }    
    }

    IEnumerator DoorOpensToNextScene()
    {
        yield return new WaitForSeconds(0.5f);
        anim.Play("DoorOpens");            //Animate door
        sfx.PlaySFX(sfx.door);             //Play door opens sfx 
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
