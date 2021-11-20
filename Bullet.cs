using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 40.0f;
    private float topBound = 25;
    private float lowerBound = -70;
    public float verticalMove;
    public bool moveBullet;

    void Start()
    {
        moveBullet = false;
    }

    public void PointerDown()
    {
        moveBullet = true;
    }

    public void PointerUp()
    {
        moveBullet = false;
    }

    void Update()
    {
       // bulletMovement();
        FixedUpdate();

         //destroy bullet off screen or when hitting object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }

    private void bulletMovement()
    {
        if (moveBullet)
        {
            verticalMove = speed;
        }
        else
        {
            verticalMove = 0;
        }
    }
   
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}