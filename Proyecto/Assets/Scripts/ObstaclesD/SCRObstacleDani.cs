using UnityEngine;
[RequireComponent(typeof(MeshCollider))]

public class SCRObstacleDani : MonoBehaviour
{
   protected virtual void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("Obstacle Detected");
    }
}
