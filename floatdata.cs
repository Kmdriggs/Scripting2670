using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class floatdata : MonoBehaviour
{

    public class FloatData : ScriptableObject
    {
        public float value;
        public void AddToValue(float num)
        {
            value += num;
        }

    }
    
}
