using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitArea : MonoBehaviour
{
    ExhibitEffect exhibitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Guest")){
            exhibitEffect.DoGuestEnterEffect(collision.gameObject.GetComponent<GuestData>());
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Guest")){
            exhibitEffect.DoGuestStayEffect(collision.gameObject.GetComponent<GuestData>());
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Guest")){
            exhibitEffect.DoGuestExitEffect(collision.gameObject.GetComponent<GuestData>());
        }
    }
}
