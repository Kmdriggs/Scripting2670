using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 40.0f;
    private float topBound = 25;
    private float lowerBound = -70;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //destroy bullet off screen
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
