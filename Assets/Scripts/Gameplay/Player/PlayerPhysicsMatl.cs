using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysicsMatl : MonoBehaviour
{
    [SerializeField] bool changeFriction;
    [SerializeField] PhysicsMaterial2D slippery;
    [SerializeField] PhysicsMaterial2D rough;
    CapsuleCollider2D capsuleCol;

    void Start()
    {
        changeFriction = true;
        capsuleCol = GetComponent<CapsuleCollider2D>();

    }

    void Update()
    {
        if (transform.position.y < -1 && changeFriction)
        {
            changeFriction = false;
            StartCoroutine(ChangeMaterialSequence());  
        }
    }

    IEnumerator ChangeMaterialSequence()
    {
        capsuleCol.sharedMaterial = rough;
        yield return new WaitForSeconds(0.3f);
        capsuleCol.sharedMaterial = slippery;
        changeFriction = true;
    }
}
