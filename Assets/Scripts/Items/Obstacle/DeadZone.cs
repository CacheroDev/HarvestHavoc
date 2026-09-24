using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour, IDeadZone
{
    [SerializeField] GameObject player;
    [SerializeField] SoundFX sfx;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        sfx = GameObject.FindGameObjectWithTag("SFX").GetComponent<SoundFX>();
    }

    void Update()
    {
        
    }

    public void DeadZoneEffect()
    {
        player.GetComponent<DisablePlayer>().disable = true;
        //deadzone prompt
        player.GetComponent<PlayerHP>().decreaseHP = true;
        sfx.PlaySFX(sfx.fire);
        StartCoroutine(DeadzoneSequence());
    }

    IEnumerator DeadzoneSequence()
    {
        yield return new WaitForSeconds(2);
        player.transform.position = Vector2.zero;
    }
}
