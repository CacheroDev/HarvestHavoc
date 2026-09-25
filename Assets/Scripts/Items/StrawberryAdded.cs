using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class StrawberryAdded : MonoBehaviour, IStrawberry
{
    //[SerializeField] TextMeshProUGUI fruitText;
    [SerializeField] bool readyToAdd;
    [SerializeField] SoundFX sfx;

    void Start()
    {
        readyToAdd = true;
        sfx = GameObject.FindGameObjectWithTag("SFX").GetComponent<SoundFX>();
    }

    void Update()
    {
        
    }
    public void AddStrawberry()
    {
        if (readyToAdd)
        {
            readyToAdd = false;
            sfx.PlaySFX(sfx.fruit);
            SuperObject.instance.fruit++;
            //fruitText.text = $"Fruit: {SuperObject.instance.fruit}";
            Destroy(gameObject);
        }
    }
}
