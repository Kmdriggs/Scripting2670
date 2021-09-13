using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEvents;

public class coderoutinebehavior : MonoBehaviour
{
	public UnityEvent startEvent;
	public bool canRun = true;
	public float holeTime = 2f;
	private WaitForSeconds wfs;
 

    IEnumerator Start()
    {
		wfs = new WaitForSeconds(holdTime);

		while (canRun)
		{
			yield return wfs;
			startEvent.Invoke();
		}
    }
}
