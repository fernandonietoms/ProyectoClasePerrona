using UnityEngine;
using UnityEngine.Events;

public class CoinsCounter : MonoBehaviour
{
    static int coins = 0;
    public static int Coins { get { return coins; } set { coins += value; CoinCollected.Invoke(); } }


    public static UnityEvent CoinCollected = new();
}
