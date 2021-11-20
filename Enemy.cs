using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 40.0f;
    private float topBound = -75;
    private GameObject restartGame;

    void Start()
    {
        restartGame = GameObject.Find("RestartButton");
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //destroy enemy if off screen
        if (transform.position.z < topBound)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
