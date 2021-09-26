using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float speed = 15;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * -1 * Time.deltaTime * speed);

        if (transform.position.z < startPos.z - 25)
        {
            transform.position = startPos;
        }
    }
}
