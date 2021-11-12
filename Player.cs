using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 50.0f;
    public float xRange = 60.0f;

    public GameObject bullet;

    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
             transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);


        //Launch Bullet
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }
    }
}
