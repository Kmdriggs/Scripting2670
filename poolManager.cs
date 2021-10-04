using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolManager : MonoBehaviour
{
    public list<GameObject> pool;
    private int 1;

    public void UseNext()
    {
        if(pool.Capacity > 0)
        {
            pool[i].SetActive(true);
            i++;
        }
        else
        {
            i = 0;
        }
    }
}
