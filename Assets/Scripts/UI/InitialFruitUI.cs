
using UnityEngine;
using TMPro;

public class InitialFruitUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI fruitText;

    void Start()
    {
        fruitText.text = $"Fruit: {SuperObject.instance.fruit}";
    }
}
