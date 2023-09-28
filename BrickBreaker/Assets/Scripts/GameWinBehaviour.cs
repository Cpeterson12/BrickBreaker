using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameWinBehaviour : MonoBehaviour
{
    public IntData score;
    public UnityEvent topScore;

    public void Update()
    {
        if (score.value == 36)
        {
            topScore.Invoke();
        }
    }
}
