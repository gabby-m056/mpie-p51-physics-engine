using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float position = 0.0f
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Rigidbody rb = GetComponent<Rigidbody>();
        if(Input.GetKey(KeyCode.A)){
            position +=1;
        }
        if(Input.GetKey(KeyCode.D)){
            position -=1;
        }
        if(Input.GetKey(KeyCode.W)){
            speed +=1;
        }
        if(Input.GetKey(KeyCode.S)){
            speed -=1;
        }
        
        rb.AddForce(new Vector3(position, 0.0f,-speed));
    }
}
