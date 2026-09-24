using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class DoorOpener : MonoBehaviour, IDoor
{
    [SerializeField] GameObject player;
    [SerializeField] public bool keyInHand;
    [SerializeField] float duration;
    [SerializeField] TextMeshProUGUI centerText;
    [SerializeField] GameObject centerBoxHolder;
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
            Debug.Log("Find key");
            StartCoroutine(CenterTextPrompt());
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

    IEnumerator CenterTextPrompt()
    {
        centerBoxHolder.SetActive(true);
        centerText.text = "Find the key";
        yield return new WaitForSeconds(2);
        centerBoxHolder.SetActive(false);
        centerText.text = "";
    }
}
