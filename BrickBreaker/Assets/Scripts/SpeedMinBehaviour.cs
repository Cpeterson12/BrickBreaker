using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMinBehaviour : MonoBehaviour
{
    public float minSpeed = 150f;
    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void Update() 
    {
        if(rb.velocity.magnitude < minSpeed)
        {
            Vector3 velocity = rb.velocity;
            velocity = velocity.normalized * minSpeed;
            rb.velocity = velocity;
        }
    }
}
