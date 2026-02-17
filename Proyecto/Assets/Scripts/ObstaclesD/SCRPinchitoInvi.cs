using UnityEngine;

public class SCRPinchitoInvi : SCRObstacleDani
{
    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        Debug.Log("Nau Nau");
    }
}
