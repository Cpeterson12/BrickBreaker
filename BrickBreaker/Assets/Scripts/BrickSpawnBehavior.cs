using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawnBehavior : MonoBehaviour
{
    public GameObject brickPrefab;
    public IntData numBricks;
    public BrickPosList[] brickPositionsOptions;
    public List<GameObject> spawnedBricks;
    public void SpawnBricks()
    {

        BrickPosList positions = brickPositionsOptions[Random.Range(0, brickPositionsOptions.Length)];
       
        for(int i = 0; i < numBricks.value; i++)
        {
            Vector3 position = positions.positions[i];

            GameObject brick = Instantiate(brickPrefab, position, Quaternion.identity);
            spawnedBricks.Add(brick);
        }
    }
    public void DeleteAllBricks() 
    {
        foreach (GameObject brick in spawnedBricks)
        {
            Destroy(brick);
        }

        spawnedBricks.Clear();
    }
}