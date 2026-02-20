using TMPro;
using UnityEngine;

public class CONT_Hud : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinCounter;

    private void Awake()
    {
        SCR_CoinsCollection.CoinCollected.AddListener(UpdateCoinText);
    }

    void UpdateCoinText()
    {
        coinCounter.text = SCR_CoinsCollection.Coins.ToString();
    }
}
