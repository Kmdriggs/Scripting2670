using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineLimitsBehavior : MonoBehaviour
{
    public float limitNum;
    private Vector3 positionVector3 = new Vector3();

    private WaitForFixedUpdate wffuObj;

    private void Start()
    {
        wffuObj = new WaitForFixedUpdate();
        positionVector3 =  transform.position;
        RunCoroutine();

    }

    public void RunCoroutine()
    {
        StartCoroutinr(routine:CoroutineWithLimit());
    }

    private IEnumerator CoroutineWithLimit()
    {
        while (transform.position.x < limitNum)
        {
            positionVector3.x += 0.1f;
            transform.Translate(positionVector3)
            yield return wffuObj;
        }
    }
}
