using UnityEngine;

public class SCRPinchitoInvi : SCR_ObstacleDani
{
    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        Debug.Log("Nau Nau");
    }
}
