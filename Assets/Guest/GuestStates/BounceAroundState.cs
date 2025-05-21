using System;
using System.Collections;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableObjects/GuestStates/BounceAroundState")]
public class BounceAroundState : GuestState
{
    [SerializeField] float speed = 1f;

    protected override void InnerEnterState()
    {
        guest.GetComponent<Rigidbody2D>().AddForce(UnityEngine.Random.insideUnitCircle.normalized * speed, ForceMode2D.Impulse);
    }
    protected override void InnerUpdateState()
    {
        guest.GetComponent<Rigidbody2D>().AddForce(guest.transform.forward * speed);
    }


    protected override void InnerExitState() { }
}