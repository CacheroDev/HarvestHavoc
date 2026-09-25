using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySceneLoader : MonoBehaviour
{
    [SerializeField] float timeToLoad;

    void Start()
    {
        StartCoroutine(LoadSequence());
    }

    void Update()
    {
        
    }

    IEnumerator LoadSequence()
    {
        yield return new WaitForSeconds(timeToLoad);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
