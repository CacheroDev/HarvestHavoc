using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawberryAdded : MonoBehaviour, IStrawberry
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void AddStrawberry()
    {
        SuperObject.instance.fruit++;
        //Debug.Log("Strawberry plus");
        Destroy(gameObject);
    }
}
