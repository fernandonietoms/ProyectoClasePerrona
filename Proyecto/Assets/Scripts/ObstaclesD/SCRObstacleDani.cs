using System.Collections;
using UnityEngine;
[RequireComponent(typeof(MeshCollider))]

/// <summary>
/// This script is the parent of all the Obstacles
/// </summary>
[RequireComponent(typeof(MeshCollider))]
public class SCR_ObstacleDani : MonoBehaviour
{
    [Header("Obstacle Components")]
    [SerializeField] bool canMove = false;
    [SerializeField, Range(0, Mathf.Infinity)] float obstacleSpeed = 1.0f;
    [SerializeField] float waitingTime = 0.0f;
    [SerializeField] Transform startLocation;
    [SerializeField] Transform endLocation;
    bool isMovingToEnd = true;
    Coroutine waitingTimeCoroutine;

    protected virtual void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("Obstacle Detected");
    }

    private void Start()
    {
        if (canMove)
        {
            transform.position = startLocation.position;
        }
    }

    private void Update()
    {
        if (canMove)
        {
            if (isMovingToEnd)
            {
                if (Vector3.Distance(transform.position, endLocation.position) < 0.01f)
                {
                    if (waitingTimeCoroutine == null)
                        waitingTimeCoroutine = StartCoroutine(WaitingTimer());
                }
                transform.position = Vector3.MoveTowards(transform.position, endLocation.position, Time.deltaTime * obstacleSpeed);
            }
            else
            {
                if (Vector3.Distance(transform.position, startLocation.position) < 0.01f)
                {
                    if (waitingTimeCoroutine == null)
                        waitingTimeCoroutine = StartCoroutine(WaitingTimer());
                }
                transform.position = Vector3.MoveTowards(transform.position, startLocation.position, Time.deltaTime * obstacleSpeed);
            }
        }
    }

    IEnumerator WaitingTimer()
    {
        yield return new WaitForSeconds(waitingTime);
        isMovingToEnd = !isMovingToEnd;
        StopCoroutine(waitingTimeCoroutine);
        waitingTimeCoroutine = null;
    }
}
