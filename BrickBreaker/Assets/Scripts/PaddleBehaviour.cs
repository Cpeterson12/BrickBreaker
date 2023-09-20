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
        moveCoroutine = StartCoroutine(MoveContinuously());
    }

    public void OnPointerUp()  
    {
        StopCoroutine(moveCoroutine); 
    }
    
    IEnumerator MoveContinuously()
    {
        while(true) 
        {
            mover.Move(transform);
            yield return null;
        }
    }
}
