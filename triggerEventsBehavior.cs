using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerEventsBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    
    
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        
    }
}
