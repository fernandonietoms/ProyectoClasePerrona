using UnityEngine;

public class Bolita_ObstacleNavaja : Bolita_Obstacle
{
    protected override void OnCollisionEnter(UnityEngine.Collision collision)
    {
        base.OnCollisionEnter(collision);
        Debug.Log("Dañito");

        if (collision.gameObject.TryGetComponent(out NewMov_Bolita playerController))
        {
            Debug.Log("Is Player");
        }
    }
}
