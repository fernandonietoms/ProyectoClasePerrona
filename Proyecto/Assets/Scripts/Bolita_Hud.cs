using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Bolita_Hud : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinCounter;
    [SerializeField] Image lifeBar;

    float lifePlayerHud = Bolita_PlayerMove.lifePlayer;

    private void Awake()
    {
        Bolita_CoinsCollectorT.CoinsCollected.AddListener(UpdateCoinText);
        Bolita_LifeBar.LifeDecrease.AddListener(UpdateLifeBar);
    }

    void UpdateCoinText()
    {
        coinCounter.text = Bolita_CoinsCollectorT.Coins.ToString();
    }

    void UpdateLifeBar()
    {
        lifeBar.fillAmount = Bolita_PlayerMove.lifePlayer / lifePlayerHud;
    }
}
