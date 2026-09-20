using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeVerticalMovement : MonoBehaviour
{
    [SerializeField] public bool upperLimit;
    [SerializeField] public bool lowerLimit;
    [SerializeField] bool stop;
    [SerializeField] bool shake;
    [SerializeField] bool moveDown;
    [SerializeField] bool moveUp;
    [SerializeField] float speedUp;
    [SerializeField] float speedDown;
    [SerializeField] float origSpeedUp;
    [SerializeField] float origSpeedDown;
    //[SerializeField] Vector2 origPos;
    [SerializeField] bool initMovement;
    [SerializeField] public bool enableUpperBoxCol;
    [SerializeField] public bool enableLowerBoxCol;

    void Start()
    {
        initMovement = true;
        upperLimit = false;
        lowerLimit = false;
        //origPos = transform.position;
        origSpeedUp = speedUp;
        origSpeedDown = speedDown;
    }

    void Update()
    {
        if (initMovement)
        {
            initMovement = false;
            moveUp = true;
        }
        if (upperLimit)
        {
            upperLimit = false;
            moveUp = false;
            StartCoroutine(StopShakeMoveDown());
        }
        if (lowerLimit)
        {
            lowerLimit = false;
            moveDown = false;
            StartCoroutine(StopMoveUp());
        }
        if (stop)
        {
            speedUp = 0;
            speedDown = 0;
        }
        if (moveUp)
        {
            speedUp = origSpeedUp;
            transform.Translate(Vector2.up * speedUp * Time.deltaTime);
            enableUpperBoxCol = true;
        }
        if (moveDown)
        {
            speedDown = origSpeedDown;
            transform.Translate(Vector2.down * speedDown * Time.deltaTime);
            enableLowerBoxCol = true;
        }
        if (shake)
        {
            //transform.localPosition = new Vector2(1,0);
            //StartCoroutine(ShakeSequence());
        }


    }

    IEnumerator StopShakeMoveDown()
    {
        stop = true;
        moveDown = false;
        moveUp = false;
        shake = false;
        yield return new WaitForSeconds(1);
        shake = true;
        yield return new WaitForSeconds(3);
        stop = false;
        moveDown = true;
        moveUp = false;
        shake = false;
    }

    IEnumerator StopMoveUp()
    {
        stop = true;
        moveDown = false;
        moveUp = false;
        yield return new WaitForSeconds(1);
        Debug.Log("Animation and juicing");
        yield return new WaitForSeconds(1);
        stop = false;
        moveDown = false;
        moveUp = true;
    }
    //IEnumerator ShakeSequence()
    //{

    //    yield return new WaitForSeconds(1);
    //}
}
