using UnityEngine;

public class Bolita_ObstacleNavaja : Bolita_Obstacle
{
    protected override void OnCollisionEnter(UnityEngine.Collision collision)
    {
        base.OnCollisionEnter(collision);
        Debug.Log("Dañito");

        if (collision.gameObject.TryGetComponent(out Bolita_PlayerMove playerController))
        {
            Debug.Log("Is Player");
            GetComponent<Renderer>().material.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
    }
}
