using UnityEngine;
using UnityEngine.Events;

public class Bolita_LifeBar : MonoBehaviour
{
    public static float Lifes { get { return Bolita_PlayerMove.lifePlayer; } 
        set { Bolita_PlayerMove.lifePlayer -= value; LifeDecrease.Invoke(); } }

    public static UnityEvent LifeDecrease = new();
}
