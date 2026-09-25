using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    [SerializeField] GameObject musicManager;

    void Start()
    {
        musicManager = GameObject.FindGameObjectWithTag("MusicManager");
    }

    void Update()
    {
        if (SuperObject.instance.tellStory == false)
        {
            Destroy(musicManager);
            //Debug.Log("Destroy OnLoad");
        }
        else
        {
            DontDestroyOnLoad(musicManager);
        }
    }
}
