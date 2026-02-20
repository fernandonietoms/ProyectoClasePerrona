using UnityEngine;
using UnityEngine.Events;

public class Bolita_CoinsCollectorT : MonoBehaviour
{
    static int coins = 0;

    public static int Coins { get { return coins; } set { coins += value; CoinsCollected.Invoke(); } }

    public static UnityEvent CoinsCollected = new();

}
