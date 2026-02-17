using UnityEngine;

public class SCR_InvisibleObstacle : SCR_Obstacle
{
    protected override void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Tu no pasarás!");
        if (collision.gameObject.TryGetComponent
            (out CONT_PlayerController playerController))
        {
            collision.gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
        base.OnCollisionEnter(collision);
    }
}
