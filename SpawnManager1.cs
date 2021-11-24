using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class SpawnManager1 : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;
    public GameObject[] EnemyPrefabs;
    private float spawnRangeX = 65;
    private float spawnPosZ = 50;
    private float startDelay = 1;
    private float spawnInterval = 1.5f;
    
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
     //   UpdateScore(0);
    }

    void SpawnRandomEnemy()
    {
        int EnemyIndex = Random.Range(0, EnemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(EnemyPrefabs[EnemyIndex], spawnPos, EnemyPrefabs[EnemyIndex].transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            myTrigger.Invoke();
        }
    }

 //   public void UpdateScore(int scoreToAdd)
 //   {
  //      score += scoreToAdd;
  //      scoreText.text = " " + score;
 //   } 
}
