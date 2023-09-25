using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OutofBoundsBehaviour : MonoBehaviour
{
    public UnityEvent EndEvent;
   public void OnTriggerEnter(Collider other)
   {
      OutOfBoundsEvent();
   }

   public void OutOfBoundsEvent()
   {
      EndEvent.Invoke();
   }
}
