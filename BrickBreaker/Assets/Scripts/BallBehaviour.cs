using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallBehaviour : MonoBehaviour
{
   public FloatData ballSpeed;
   public Rigidbody rigidbody { get; private set; }

   public void Awake()
   {
      this.rigidbody = GetComponent<Rigidbody>();
   }

   public void Start()
   {
      GiveTrajectory();
   }

   public void GiveTrajectory()
   {
      Vector3 force = Vector3.zero;
      force.x = Random.Range(-1f, 1f);
      force.y = 1f;
      this.rigidbody.AddForce(force.normalized * this.ballSpeed.value);
   }
}
