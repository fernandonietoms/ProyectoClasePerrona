using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// This script is the parent of all the Obstacles
/// </summary>
[RequireComponent(typeof(MeshCollider))]
public class SCR_Obstacle : MonoBehaviour
{
    protected virtual void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("Obstacle Detected");
        Destroy(gameObject);
    }
}
