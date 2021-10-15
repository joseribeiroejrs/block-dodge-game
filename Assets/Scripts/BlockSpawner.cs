using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    public float timeBetweenWaves = 2f;
    public float timeToSpawn = 1.5f;

    void Update()
    {
        if (Time.time > timeToSpawn)
		{
            timeToSpawn = Time.time + timeBetweenWaves;
            respawBlocks();
        }
    }

    void respawBlocks ()
	{
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i]);
            }
        }
    }
}
