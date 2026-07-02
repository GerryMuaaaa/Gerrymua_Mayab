using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //primitive data types
    int _varInt = 5;
    float _varFloat = 1.0f;
    string _varString = "Hello";
    bool _varBool = false;
    //complex data types

    Collider _playerCollider;
   public Rigidbody rb;


    void Start()
    {
        Debug.Log("Hola jijija");   
    }

    void Update()
    {
       rb.linearVelocity = new Vector3(_varInt,0f,0f); 
    }
    private void FixedUpdate()
    {
        
    }
}
