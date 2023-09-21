using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLimitBehaviour : MonoBehaviour
{

    public float maxSpeed = 200f;

    void Update() 
    {
        Vector3 vel = GetComponent<Rigidbody>().velocity;
      
        if(vel.magnitude > maxSpeed) 
        {
            Vector3 limitedVel = vel.normalized * maxSpeed;
            GetComponent<Rigidbody>().velocity = limitedVel; 
        }
    }

}
