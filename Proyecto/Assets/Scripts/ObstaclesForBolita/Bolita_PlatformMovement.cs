using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshCollider))]
public class Bolita_PlatformMovement : MonoBehaviour
{
    [Header("Platforms Components")]
    [SerializeField] bool canMove = false;
    [SerializeField, Range(0, Mathf.Infinity)] float platformSpeed = 1.0f;
    [SerializeField] float waitingTime = 0.0f;
    [SerializeField] Transform startLocation;
    [SerializeField] Transform endLocation;
    bool isMovingToEnd = true;
    Coroutine waitingTimeCoroutine;

    protected virtual void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("This Platform is moving");
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
                transform.position = Vector3.MoveTowards(transform.position, endLocation.position, Time.deltaTime * platformSpeed);
            }
            else
            {
                if (Vector3.Distance(transform.position, startLocation.position) < 0.01f)
                {
                    if (waitingTimeCoroutine == null)
                        waitingTimeCoroutine = StartCoroutine(WaitingTimer());
                }
                transform.position = Vector3.MoveTowards(transform.position, startLocation.position, Time.deltaTime * platformSpeed);
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
