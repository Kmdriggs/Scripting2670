using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    private float spawnRangeX = 55;
    private float spawnPosZ = 50;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    void Update()
    {
       
    }

    void SpawnRandomEnemy()
    {
        int EnemyIndex = Random.Range(0, EnemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(EnemyPrefabs[EnemyIndex], spawnPos, EnemyPrefabs[EnemyIndex].transform.rotation);
    } 
}
