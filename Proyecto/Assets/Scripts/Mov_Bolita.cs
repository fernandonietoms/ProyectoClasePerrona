using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class NewMov_Bolita : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBodyPlayer;
    [SerializeField] Transform cameraTransform;

    bool moveForward;
    bool moveBackward;
    bool moveLeft;
    bool moveRight;

    [SerializeField, Range(0.001f,0.1f)]
    float speed = 0.01f;
    [SerializeField, Range(5.0f, 15.0f)]
    float jump = 10f;
    [SerializeField]
    float jumpOffset = 0.5f;


    // Update is called once per frame
    void Update()
    {
        // Move Forward Instruction ----------------------------------

        // If the W key is pressed down...
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Enable Moving
            moveForward = true;
        }
        // If the W key is stopped pressed...
        if (Input.GetKeyUp(KeyCode.W))
        {
            // Disable moving
            moveForward = false;
        }
        if (moveForward)
        {
            rigidBodyPlayer.AddForce(cameraTransform.forward * speed, ForceMode.Impulse);
        }

        // Move Backward Instruction ---------------------------------

        // If the S key is pressed down...
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Enable Moving
            moveBackward = true;
        }
        // If the A key is stopped pressed...
        if (Input.GetKeyUp(KeyCode.S))
        {
            // Disable moving
            moveBackward = false;
        }
        if (moveBackward)
        {
            rigidBodyPlayer.AddForce(-cameraTransform.forward * speed, ForceMode.Impulse);
        }

        // Move Left Instruction -------------------------------

        // If the A key is pressed down...
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Enable Moving
            moveLeft = true;
        }
        // If the A key is stopped pressed...
        if (Input.GetKeyUp(KeyCode.A))
        {
            // Disable moving
            moveLeft = false;
        }
        if (moveLeft)
        {
            rigidBodyPlayer.AddForce(-cameraTransform.right * speed, ForceMode.Impulse);
        }

        // Move Right Instruction ------------------------------

        // If the D key is pressed down...
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Enable Moving
            moveRight = true;
        }
        // If the D key is stopped pressed...
        if (Input.GetKeyUp(KeyCode.D))
        {
            // Disable moving
            moveRight = false;
        }
        if (moveRight)
        {
            rigidBodyPlayer.AddForce(cameraTransform.right * speed, ForceMode.Impulse);
        }

        // Move Jump Instruction ------------------------------

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if ((rigidBodyPlayer.linearVelocity.y <= jumpOffset) &&
              (rigidBodyPlayer.linearVelocity.y >= -jumpOffset))
            {
                // Jump 
                rigidBodyPlayer.AddForce(Vector3.up * jump, ForceMode.Impulse);
            }
        }

    }
}
