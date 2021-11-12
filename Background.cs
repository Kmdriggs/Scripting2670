using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Vector3 startPos;
    private float speed = 30;
 
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        //background repeat
        if (transform.position.z < startPos.z -200)
        {
            transform.position = startPos;
        }

        //background movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
