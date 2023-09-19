//code assisted by ClaudeAI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PaddleBehaviour : MonoBehaviour
{
    public MoveData mover; 
    Coroutine moveCoroutine;
    
    public void OnPointerDown() 
    {
        StartCoroutine(MoveContinuously(1));
    }
    
    public void OnPointerDownTwo() 
    {
        StartCoroutine(MoveContinuously(-1));
    }
    
    public void OnPointerUp()  
    {
        StopCoroutine(MoveContinuously(-1)); 
    }
    public void OnPointerUpTwo()  
    {
        StopCoroutine(MoveContinuously(1)); 
    }

    IEnumerator MoveContinuously(int direction)
    {
        while(true) 
        {
            mover.direction = direction;
            mover.Move(transform);
            yield return null;
        }
    }
}
