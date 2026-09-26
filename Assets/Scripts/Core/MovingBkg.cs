using System.Collections;

using UnityEngine;

public class MovingBkg : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int pattern;

    MeshRenderer mesh;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        pattern = 0;
        StartCoroutine(RandomPattern());
    }

    void Update()
    {
        if (pattern == 1)
        {
            mesh.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, speed * Time.deltaTime);
        }
        if (pattern == 2)
        {
            mesh.material.mainTextureOffset += new Vector2(-speed * Time.deltaTime, speed * Time.deltaTime);
        }
        if (pattern == 3)
        {
            mesh.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, -speed * Time.deltaTime);
        }
        if (pattern == 4)
        {
            mesh.material.mainTextureOffset += new Vector2(-speed * Time.deltaTime, -speed * Time.deltaTime);
        }
    }

    IEnumerator RandomPattern()
    {
        while (true)
        {
            pattern = Random.Range(1, 5);
            yield return new WaitForSeconds(10);
        }
    }
}
