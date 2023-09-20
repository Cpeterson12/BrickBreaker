using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawnBehavior : MonoBehaviour
{
    public GameObject brickPrefab;
    public IntData numBricks;

    public void SpawnBricks()
    {
        for(int i = 0; i < numBricks.value; i++) 
        {
            Vector3 randomPosition = new Vector3
            (
                Random.Range(-8f, 8f), 
                Random.Range(0, 5.3f), 
                0f
            );

            Instantiate(brickPrefab, randomPosition, Quaternion.identity);
        }
    }
}