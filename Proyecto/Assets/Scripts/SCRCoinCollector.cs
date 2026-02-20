using UnityEngine;

public class SCRCoinCollector : MonoBehaviour
{
    [SerializeField] int value = 1;
    private void OnCollisionEnter(Collision collision)
    {
        CoinsCounter.Coins = value;
        Destroy(gameObject);
        
    }
}
