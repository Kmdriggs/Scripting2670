using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent respondEvent;

    private void Start()
    {
        gameActionObj.raise += Respond;
       // gameActionObj.raiseWithBool += RespondWithBool;
    }

    private void Respond()
    {
        respondEvent.Invoke();
    }

   
}
