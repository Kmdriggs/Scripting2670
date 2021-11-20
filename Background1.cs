using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background1 : MonoBehaviour
{
    private Vector3 startPos;
    private float speed = 30;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (transform.position.z < startPos.z -200)
        {
            transform.position = startPos;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
