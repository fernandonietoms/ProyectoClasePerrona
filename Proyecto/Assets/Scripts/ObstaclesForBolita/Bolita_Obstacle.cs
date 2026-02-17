using UnityEngine;

[RequireComponent (typeof(MeshCollider))]
public class Bolita_Obstacle : MonoBehaviour
{
   protected virtual void OnCollisionEnter(UnityEngine.Collision collision)
   {
        Debug.Log("Obstacle Detected");
   }
}
