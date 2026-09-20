using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageColor : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] Image myImage;
    [SerializeField] bool change;

    void Start()
    {
        door = GameObject.FindGameObjectWithTag("Door");
        myImage = gameObject.GetComponent<Image>();
        change = true;
    }

    void Update()
    {
        if (door.GetComponent<DoorOpener>().keyInHand && change)
        {
            change = false;
            StartCoroutine(Sequence());
        }    
    }

    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(2.2f);
        myImage.color = Color.white;
    }
    
}
