using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestManager : MonoBehaviour
{
    List<GuestStateMachine> guests;

    public void AddGuest(GuestStateMachine guest){
        guests.Add(guest);
    }

    public void RemoveGuest(GuestStateMachine guest){
        guests.Remove(guest);
    }
}
