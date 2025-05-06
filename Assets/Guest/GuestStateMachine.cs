using System;
using System.Collections;
using UnityEngine;

public class GuestStateMachine : MonoBehaviour
{
    [SerializeReference]
    GuestState startingState;

    [SerializeReference]
    DeathState deathState;


    GuestState currentState;

    public GuestData guestData;

    private bool changingState = false;
        void Start()
    {
        EnterState(startingState);
    }

    void FixedUpdate() {
        if (!changingState)
            currentState.UpdateState();
    }

    public void EnterState(GuestState state){
        changingState = true;
        GuestState newState = Instantiate(state);
        if(currentState != null){
        currentState.ExitState();
        }
        currentState = newState;
        newState.EnterState(this);
        changingState = false;
    }

    public void StartCooldown(float time, Action action){
        StartCoroutine(CooldownTimer(time,action));
    }

    public void DisableMe(){
        this.enabled = false;
    }

    IEnumerator CooldownTimer(float time, Action action){
        Debug.Log("Time: " + time);
        yield return new WaitForSeconds(time);
        action.Invoke();
    }

    private void OnDestroy() {
        EnterState(deathState);
    }
}

