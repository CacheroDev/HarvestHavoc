
using UnityEngine;

public class MovingBkg : MonoBehaviour
{
    [SerializeField] float speed;

    MeshRenderer mesh;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        mesh.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, speed * Time.deltaTime);
    }
}
