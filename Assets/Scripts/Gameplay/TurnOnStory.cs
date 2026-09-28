
using UnityEngine;

public class TurnOnStory : MonoBehaviour
{
    void Start()
    {
        SuperObject.instance.tellStory = true;
    }
}
