using System;
using UnityEngine;
using UnityEngine.Rendering;
[RequireComponent(typeof(Rigidbody))]
public class SControl: MonoBehaviour
{
    [SerializeField] Rigidbody playerRigidbody;
    bool moveforward;
    bool moveback;
    bool moveleft;
    bool moveright;
    public Transform GroundCheck;     
    public float radioDeteccion = 0.1f; 
    public LayerMask layerGround;
    public float jumpForce = 10f;
    bool isGrounded;
    [SerializeField,Range(0.001f,0.01f)]
    float speed = 0.01f;
    float jumpoffset = 0.1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start Message");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W");
            moveforward = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("W");
            moveforward = false;
        }
        if (moveforward)
        {
           playerRigidbody.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }

            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("S");
                moveback = true;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                Debug.Log("S");
                moveback = false;}
            if (moveback)
            {
               playerRigidbody.AddForce(Vector3.back * speed, ForceMode.Impulse);
            }

                if (Input.GetKeyDown(KeyCode.A))
                {
                    Debug.Log("A");
                    moveleft = true;
                }
                    if (Input.GetKeyUp(KeyCode.A))
                {
                    Debug.Log("A");
                    moveleft = false;
                }
                if (moveleft)
                {
                   playerRigidbody.AddForce(Vector3.left * speed, ForceMode.Impulse);
                }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D");
            moveright = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("D");
            moveright = false;
        }
        if (moveright)
        {
           playerRigidbody.AddForce(Vector3.right * speed, ForceMode.Impulse);
        }

        isGrounded = Physics.CheckSphere(GroundCheck.position, radioDeteccion, layerGround);

        
        Debug.Log("Ground: " + isGrounded);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            if((GetComponent<Rigidbody>().linearVelocity.y <= jumpoffset) &&
                (GetComponent<Rigidbody>().linearVelocity.y >= -jumpoffset))
                {
                   playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                }

    }
}
}

