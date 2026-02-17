using UnityEngine;

public class SCR_DamageObstacle : SCR_Obstacle
{
    protected override void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Dañito");
        // Si el objeto con el que colisiona.
        // Es un GameObject.
        // Busco el componente CONT_PlayerController y si lo tiene
        // Guárdalo en la variable playerController y valida la condición :D
        if (collision.gameObject.TryGetComponent
            (out CONT_PlayerController playerController))
        {
            collision.gameObject.transform.position = new Vector3(0, 12, -8);
        }
        base.OnCollisionEnter(collision);
    }
}
