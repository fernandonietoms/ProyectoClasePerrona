using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class CONT_PlayerController : MonoBehaviour
{
    bool moveForward;
    [SerializeField, Range(0.001f, 0.1f)]
    float speed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        moveForward = Input.GetKey(KeyCode.W);
        
        // If the W key is pressed down...
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Enable moving
            moveForward = true;
        }
        // If the W key is stopped pressed...
        if (Input.GetKeyUp(KeyCode.W))
        {
            // Disable moving
            moveForward = false;
        }

        // If moving is enabled...
        if (moveForward)
        {
            // Move the player in the given vector
            GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }
    }
}
