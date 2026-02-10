using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class esto_es_mi_codigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start message");
    }
    bool moveForward,moveRight,moveBack,moveLeft;
    [SerializeField,Range(0.01f,0.1f)]
    float speed=0.01f;
    // Update is called once per frame
    void Update()
    {
        
        //Si se está presionando la tecla w imprime ese mensaje
        if(Input.GetKeyDown(KeyCode.W))
        {
          moveForward=true;
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
          moveForward=false;  
          
        }
        if(moveForward)
        {
           GetComponent<Rigidbody>().AddForce(Vector3.forward*speed, ForceMode.Impulse); 
        }
        
        if(Input.GetKeyDown(KeyCode.D))
        {
          moveRight=true;
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
          moveRight=false;  
          
        }
        if(moveRight)
        {
           GetComponent<Rigidbody>().AddForce(Vector3.right*speed, ForceMode.Impulse); 
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
          moveBack=true;
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
          moveBack=false;  
          
        }
        if(moveBack)
        {
           GetComponent<Rigidbody>().AddForce(Vector3.back*speed, ForceMode.Impulse); 
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
          moveLeft=true;
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
          moveLeft=false;  
          
        }
        if(moveLeft)
        {
           GetComponent<Rigidbody>().AddForce(Vector3.left*speed, ForceMode.Impulse); 
        }
    }
}
