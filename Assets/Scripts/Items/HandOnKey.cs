using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandOnKey : MonoBehaviour, IKey
{
    [SerializeField] GameObject door;
    [SerializeField] float blinkInterval;
    [SerializeField] bool moveKey;
    [SerializeField] float speed;
    [SerializeField] SoundFX sfx;
    SpriteRenderer spriteRen;
    CapsuleCollider2D capsuleCol;

    void Start()
    {
        door = GameObject.FindGameObjectWithTag("Door");
        spriteRen = GetComponent<SpriteRenderer>();
        capsuleCol = GetComponent<CapsuleCollider2D>();
        sfx = GameObject.FindGameObjectWithTag("SFX").GetComponent<SoundFX>();
    }

    void Update()
    {
        if (moveKey)
        {
            transform.Translate(new Vector2(2 * Time.deltaTime * speed, Time.deltaTime * speed));
        }
    }

    public void KeyOnHand()
    {
        capsuleCol.enabled = false;
        StartCoroutine(KeyAlphaAndUI());
    }

    IEnumerator KeyAlphaAndUI()
    { 
        //Debug.Log("Key blinks for 2s. Key on UI highlighted. Bool to open door set to true.");
        door.GetComponent<DoorOpener>().keyInHand = true;
        sfx.PlaySFX(sfx.key);
        for (int i=0; i<4; i++)
        {
            spriteRen.color = new Vector4(spriteRen.color.r, spriteRen.color.g, spriteRen.color.b, 0.2f);
            yield return new WaitForSeconds(blinkInterval);
            spriteRen.color = new Vector4(spriteRen.color.r, spriteRen.color.g, spriteRen.color.b, 0.8f);
            yield return new WaitForSeconds(blinkInterval);
        }

        moveKey = true;
        yield return new WaitForSeconds(blinkInterval);
        Destroy(gameObject);
    }
}
