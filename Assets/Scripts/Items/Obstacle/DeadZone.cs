using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour, IDeadZone
{
    [SerializeField] GameObject player;
    [SerializeField] SoundFX sfx;
    [SerializeField] public bool prompt;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        sfx = GameObject.FindGameObjectWithTag("SFX").GetComponent<SoundFX>();
        prompt = false;
    }

    void Update()
    {
        
    }

    public void DeadZoneEffect()
    {
        player.GetComponent<PlayerHP>().decreaseHP = true;
        sfx.PlaySFX(sfx.fire);
        if (player.GetComponent<PlayerHP>().playerHP > 1)
        {
            player.GetComponent<DisablePlayer>().disable = true;
            prompt = true;
            StartCoroutine(DeadzoneSequence());
        }
    }

    IEnumerator DeadzoneSequence()
    {
        yield return new WaitForSeconds(2);
        player.transform.position = Vector2.zero;
    }
}
