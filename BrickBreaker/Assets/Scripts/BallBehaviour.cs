using System;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class BallBehaviour : MonoBehaviour
{
   public FloatData ballSpeed;
   public GameObject ball;
   public UnityEvent addScore;
   public Rigidbody rB { get; private set; }

   public void Awake()
   {
      this.rB = GetComponent<Rigidbody>();
   }

   public void Moveball()
   {
      GiveTrajectory();
   }

   public void GiveTrajectory()
   {
      Vector3 force = Vector3.zero;
      force.x = Random.Range(-1f, 1f);
      force.y = 1f;
      this.rB.AddForce(force.normalized * this.ballSpeed.value);
   }

   private void OnCollisionEnter(Collision collision)
   {
      
      Vector3 force = Vector3.zero;
      force.x = Random.Range(-1f, 1f);
      this.rB.AddForce(force.normalized * this.ballSpeed.value);
      
   }
   
   public void MoveBallBack()
   {
      GetComponent<Rigidbody>().velocity = Vector3.zero;
      GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
      ball.transform.position = new Vector3(0, -1.85f, 0);
   }
   
}
