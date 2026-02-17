using UnityEngine;
/// <summary>
/// This Script is the parent of all Obstacles
/// </summary>
[RequireComponent(typeof(MeshCollider))]

public class Obstacle1 : MonoBehaviour
{
   

   protected virtual void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("Obstacle Detected");
    }
}
