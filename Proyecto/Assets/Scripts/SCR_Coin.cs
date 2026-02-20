using UnityEngine;

public class SCR_Coin : MonoBehaviour
{
    [SerializeField] int value = 1;

    private void OnCollisionEnter(Collision collision)
    {
        SCR_CoinsCollection.Coins = value;
        Destroy(gameObject);
    }
}
