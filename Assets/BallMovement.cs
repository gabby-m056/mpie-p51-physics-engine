using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0.0f, 0.0f,speed));
    }
}
