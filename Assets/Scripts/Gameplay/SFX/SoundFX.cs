using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    [Header("----- Audio Source-----")]
    [SerializeField] AudioSource SFXSource;

    [Header("------ Audio Clip------")]
    public AudioClip fruit;
    public AudioClip fire;
    public AudioClip key;
    public AudioClip door;
    public AudioClip victory;
    public AudioClip dead;
    public AudioClip oneShortLowStep;
    public AudioClip footStep;
    public AudioClip dropFruit;

    private void Start()
    {

    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
