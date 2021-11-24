using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class GameAction : ScriptableObject
{
    public UnityAction raise;
    public UnityAction<bool> raiseWithBool;

    public void RaiseAction()
    {
        raise.Invoke();
    }

    //public void RaiseActionWithBool(bool obj)
   // {
    //    raiseWithBool.Invoke(obj);
  //  }

}
