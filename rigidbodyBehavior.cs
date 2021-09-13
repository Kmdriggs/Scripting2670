using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequiredComponeny(trigger(Rigidbody))]
public class rigidbodyBehavior : MonoBehaviour
{
    public float forces;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigibbody>();
        rb.AddExplosionForce(20, Vector3.forward, explosions 3f);
    }
}
