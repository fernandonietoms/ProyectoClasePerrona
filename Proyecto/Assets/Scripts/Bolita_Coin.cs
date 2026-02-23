using UnityEngine;

public class Bolita_Coin : MonoBehaviour
{
    [SerializeField] int coinValue = 1;
    private void OnCollisionEnter(Collision collision)
    {
        Bolita_CoinsCollectorT.Coins = coinValue;
        Destroy(gameObject);
    }

}
