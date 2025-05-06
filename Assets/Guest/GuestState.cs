using System;
using UnityEngine;


[Serializable]
public class GuestState : ScriptableObject
{
    protected GuestStateMachine guest;

    public void EnterState(GuestStateMachine guest){
        this.guest = guest;
        Debug.Log("Entering State: " + GetType().Name.ToString());
        InnerEnterState();
    }

    public void UpdateState()
    {
        InnerUpdateState();
    }

    public void ExitState()
    {
        Debug.Log("Exiting State: " + GetType().Name.ToString());
        InnerExitState();
    }

    protected void NextState(GuestState nextState){
        guest.EnterState(nextState);
    }

    protected virtual void InnerUpdateState(){}

    protected virtual void InnerEnterState(){}

    protected virtual void InnerExitState(){}
}