using System;
using UnityEngine;


[Serializable]
[CreateAssetMenu(menuName ="ScriptableObjects/GuestStates/DeathState")]
public class DeathState : GuestState
{
    protected override void InnerUpdateState(){}

    protected override void InnerEnterState(){
        guest.guestData.DoGuestDeathEffect();
        GameManager.Instance._GuestManager.RemoveGuest(guest);
    }

    protected override void InnerExitState(){}
}