using UnityEngine;

public class Bolita_Coin : MonoBehaviour
{
    [SerializeField] int value = 1;
    private void OnCollisionEnter(Collision collision)
    {
        Bolita_CoinsCollectorT.Coins = value;
        Destroy(gameObject);
    }

}
