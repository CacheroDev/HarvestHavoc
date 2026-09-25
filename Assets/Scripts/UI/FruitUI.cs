
using UnityEngine;
using TMPro;

public class FruitUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI fruitText;

    void Update()
    {
        fruitText.text = $"Fruit: {SuperObject.instance.fruit}";
    }
}
