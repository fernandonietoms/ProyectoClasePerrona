using System;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class CONT_PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody playerRigidbody;
    [Space]
    // Switches to move the player horizontally
    bool moveForward, moveBackward, moveLeft, moveRight;
    // Variable of horizontal speed force
    [SerializeField, Range(0.001f, 0.1f)]
    float speed = 0.01f;
    // Variable of jump force
    [SerializeField, Range(5.0f, 15.0f)]
    float jump = 10.0f;
    [Space]
    [SerializeField]
    float jumpOffset = 0.5f;

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        MoveVertical();
    }

    /// <summary>
    /// Function to move horizontally in the world using WASD
    /// </summary>
    void MoveHorizontal()
    {
        // Switch the boolean when the key is pressed
        moveForward = Input.GetKey(KeyCode.W);
        moveBackward = Input.GetKey(KeyCode.S);
        moveLeft = Input.GetKey(KeyCode.A);
        moveRight = Input.GetKey(KeyCode.D);

        // If moving is enabled...
        if (moveForward)
        {
            // Move the player in the given vector
            playerRigidbody.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }
        // If moving is enabled...
        if (moveBackward)
        {
            // Move the player in the given vector
            playerRigidbody.AddForce(Vector3.back * speed, ForceMode.Impulse);
        }
        // If moving is enabled...
        if (moveLeft)
        {
            // Move the player in the given vector
            playerRigidbody.AddForce(Vector3.left * speed, ForceMode.Impulse);
        }
        // If moving is enabled...
        if (moveRight)
        {
            // Move the player in the given vector
            playerRigidbody.AddForce(Vector3.right * speed, ForceMode.Impulse);
        }
    }

    /// <summary>
    /// Jump with Space key
    /// </summary>
    void MoveVertical()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If the player is not moving up or down...
            if ((playerRigidbody.linearVelocity.y <= jumpOffset) && 
                (playerRigidbody.linearVelocity.y >= -jumpOffset))
            {
                // Do the jump
                playerRigidbody.AddForce(Vector3.up * jump, ForceMode.Impulse);
            }
        }
    }
}
