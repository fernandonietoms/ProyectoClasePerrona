using System;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class SControl: MonoBehaviour
{
    bool moveforward;
    bool moveback;
    bool moveleft;
    bool moveright;
    [SerializeField,Range(0.001f,0.01f)]
    float speed = 0.01f;
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

            Debug.Log("Update Message");
            moveforward = true;
    
        }
           
        if (Input.GetKeyUp(KeyCode.W))
        {

            Debug.Log("Update Message");
            moveforward = false;
            

        }
        if (moveforward)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            Debug.Log("Update Message");
            moveback = true;
    
        }
           
        if (Input.GetKeyUp(KeyCode.S))
        {

            Debug.Log("Update Message");
            moveback = false;
            

        }
        if (moveback)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * speed, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {

            Debug.Log("Update Message");
            moveleft = true;
    
        }
           
        if (Input.GetKeyUp(KeyCode.A))
        {

            Debug.Log("Update Message");
            moveleft = false;
            

        }
        if (moveleft)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * speed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            Debug.Log("Update Message");
            moveright = true;
    
        }
           
        if (Input.GetKeyUp(KeyCode.D))
        {

            Debug.Log("Update Message");
            moveright = false;
            

        }
        if (moveright)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * speed, ForceMode.Impulse);
        }
           
        
    }
}
