
using System;
using UnityEngine;
using UnityEngine.Events;

public class BrickBehaviour : MonoBehaviour
{
   public int health = 3;
   public Renderer brickRenderer;
   public UnityEvent score;

   void Start()
   {
      if(health == 3) 
      {
         brickRenderer.material.color = Color.green;
      }
      else if(health == 2) 
      {
         brickRenderer.material.color = Color.yellow;  
      }
      else {
         brickRenderer.material.color = Color.red;
      }
   }

   public void TakeDamage() 
   {
      health--;
      if(health == 3) 
      {
         brickRenderer.material.color = Color.green;
      }
      else if(health == 2) 
      {
         brickRenderer.material.color = Color.yellow;  
      }
      else {
         brickRenderer.material.color = Color.red;
      }
      if(health <= 0)
      {
         gameObject.SetActive(false); 
      }
      score.Invoke();
   }

   private void OnCollisionEnter(Collision collision)
   {
      TakeDamage();
   }
}
