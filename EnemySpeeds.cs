using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeeds : MonoBehaviour
{
    public float enemySpeed = 15.0f;

    void Start()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(10.0f);
        enemySpeed += 5.0f;
        StartCoroutine(timer());
    }
}
