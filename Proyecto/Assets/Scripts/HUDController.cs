using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinCounter;
    private void Awake()
    {
        CoinsCounter.CoinCollected.AddListener(UpdatecoinText);
    }


    void UpdatecoinText()
    {
        coinCounter.text = CoinsCounter.Coins.ToString();

    }

}
