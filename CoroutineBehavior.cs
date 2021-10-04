﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent;
    public bool canRun = true;
    public float holdTime = 2f;
    private WaitForSeconds wfs;

    public void StartSimpleCoroutine()
    {
        StartCoroutine(routine.CoroutineSimple());
    }

    private IEnumerator CoroutineSimple()
    {
        wfs = new WaitForSeconds(holdTime);

        while (canRun)
        {
            yield return wfs;
            startEvent.Invoke();
        }
    }

    public void ChangeWaitTime(float time)
    {
        wfs = new WaitForSeconds(time);
    }

    public void StartCoroutineWithIncrease()
    {
        (StartCoroutine(routine.CoroutineWithIncrease());
    }

    private IEnumerator CoroutineWithIncrease()
    {
        wfs = new WaitForSeconds(holdTime);

        while(canRun)
        {
            yield return wfs;
            if (holdTime >= 0.1f)
            {
                holdTime -= 0.1f;
                wfs = new WaitForSeconds(holdTime);
            }
            startEvent.Invoke();
        }
    }
}
