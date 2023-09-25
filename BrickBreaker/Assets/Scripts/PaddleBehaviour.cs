//code assisted by ClaudeAI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PaddleBehaviour : MonoBehaviour
{
    public MoveData mover; 
    Coroutine moveCoroutine;
    public GameObject paddle;
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

    public void ReturnPaddle()
    {
        paddle.transform.position = new Vector3(0, -3, 0);
    }
}
