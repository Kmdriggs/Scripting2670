using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background1 : MonoBehaviour
{
    private Vector3 startPos;
    private float speed = 30;
   // private float repeatWidth;

    void Start()
    {
        startPos = transform.position;
        //repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        if (transform.position.z < startPos.z -19.5 * 15)
        {
            transform.position = startPos;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
