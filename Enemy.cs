using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
   // [SerializeField] private UnityEvent playerTrigger;
   // [SerializeField] private GameObject asteroid;
    private GameObject restartGame;
    public ScoreManager scoreManager;
    private SpawnManager1 spawnManager;
    private EnemySpeeds speedEnemy;

    private float speed;
    private float topBound = -75;
    public float rotationSpeed;
    public int pointValue;

    void Start()
    {
        speedEnemy = GameObject.Find("SpeedManager").GetComponent<EnemySpeeds>();
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager1>();
        restartGame = GameObject.Find("RestartButton");
    }

    void Update()
    {
        //speed increases
        speed = speedEnemy.enemySpeed;

        //enemy movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //enemy rotation
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        //destroy enemy if off screen
        if (transform.position.z < topBound)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.UpdateScore(1);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
