using UnityEngine;
using TMPro;

public class Bolita_Hud : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinCounter;

    private void Awake()
    {
        Bolita_CoinsCollectorT.CoinsCollected.AddListener(UpdateCoinText);
    }

    void UpdateCoinText()
    {
        coinCounter.text = Bolita_CoinsCollectorT.Coins.ToString();
    }
}
