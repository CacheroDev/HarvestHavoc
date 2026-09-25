using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour
{
    [SerializeField] SoundFX sfx;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlaySoundFX()
    {
        sfx.PlaySFX(sfx.fruit);
    }
}
