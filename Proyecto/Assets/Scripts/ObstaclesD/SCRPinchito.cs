using UnityEngine;
/// <summary>
/// This is Pinchito Script (you die)
/// </summary>
public class SCRPinchito : SCR_ObstacleDani
{

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        Debug.Log("Muelto");
        if (collision.gameObject.TryGetComponent(out SControl playerController))
        {
            Debug.Log("Is Player");
            collision.gameObject.transform.position = new Vector3(0,70,0);
        }

}
}
