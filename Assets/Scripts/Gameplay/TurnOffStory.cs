

using UnityEngine;

public class TurnOffStory : MonoBehaviour
{
    void Start()
    {
        SuperObject.instance.tellStory = false;
    }
}
