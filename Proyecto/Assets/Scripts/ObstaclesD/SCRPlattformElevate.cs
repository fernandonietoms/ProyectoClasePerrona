using UnityEngine;

public class SCRPPlattformElevate : SCR_ObstacleDani
{
    [SerializeField] private float height = 5f; 
    [SerializeField] private float speed = 2f; 

    private bool shouldElevate = false;
    private Vector3 targetPosition;

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        if (collision.gameObject.TryGetComponent(out SControl playerController))
        {
            Debug.Log("Is Player");
            shouldElevate = true;
            targetPosition = transform.position + Vector3.up * height;
        }
    }

    private void Update()
    {
        if (shouldElevate)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                speed * Time.deltaTime
            );
        }
    }
}