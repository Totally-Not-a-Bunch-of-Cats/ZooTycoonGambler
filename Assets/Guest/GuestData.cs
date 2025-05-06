using System;
using UnityEngine;

[Serializable]
public class GuestData : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float guestMultiplier = 1f;

    [SerializeField] GuestEffect effect;

    void Update()
    {
        effect.DoUpdateEffect();
    }

    public void DoGuestVisitEffect(){
        effect.DoExhibitVisitEffect();
    }

    public void DoGuestDeathEffect(){
        effect.DoDeathEffect();
    }
}
