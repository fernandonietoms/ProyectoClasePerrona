using UnityEngine;

public class Bolita_ObstacleInvisible : Bolita_Obstacle
{
    protected override void OnCollisionEnter(UnityEngine.Collision collision)
    {
        base.OnCollisionEnter(collision);
        Debug.Log("Por aqui, no que te caes");

        if(collision.gameObject.TryGetComponent(out NewMov_Bolita playerController))
        {
            Debug.Log("Is Player");
        }
    }
}
