using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
//using UnityEngine.UI;

public class DoorOpener : MonoBehaviour, IDoor
{
    [SerializeField] GameObject player;
    [SerializeField] public bool keyInHand;
    [SerializeField] float duration;
    //[SerializeField] TextMeshProUGUI centerText;
    //[SerializeField] GameObject centerBoxHolder;
    [SerializeField] public bool findTheKey;
    [SerializeField] SoundFX sfx;
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
            findTheKey = true;
            sfx.PlaySFX(sfx.oneShortLowStep);
            Debug.Log("Find key");
        }    
    }

    IEnumerator DoorOpensToNextScene()
    {
        yield return new WaitForSeconds(duration);
        anim.Play("DoorOpens");            //Animate door
        sfx.PlaySFX(sfx.door);             //Play door opens sfx 
        yield return new WaitForSeconds(duration);
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
