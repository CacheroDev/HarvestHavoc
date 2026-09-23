using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StrawberryAdded : MonoBehaviour, IStrawberry
{
    [SerializeField] TextMeshProUGUI fruitText;
    [SerializeField] bool readyToAdd;

    void Start()
    {
        readyToAdd = true;
    }

    void Update()
    {
        
    }
    public void AddStrawberry()
    {
        if (readyToAdd)
        {
            readyToAdd = false;
            SuperObject.instance.fruit++;
            fruitText.text = $"Fruit: {SuperObject.instance.fruit}";
            Destroy(gameObject);
        }
    }
}
