using UnityEngine;

public class ExhibitEffect : ScriptableObject
{

    [SerializeField] float visitValue = 1f;

    [SerializeField] GameObject exhibitObject;

    public void PlaceExhibit(){
        GameManager.Instance._ExhibitManager.AddExhibit(this);
        DoExhibitPlaceEffect();
    }

    protected void AddToScore(int score){
        GameManager.Instance._ScoreManager.AddToScore(score);
    }

    public virtual void DoGuestEnterEffect(GuestData guest){

    }

    public virtual void DoGuestStayEffect(GuestData guest){

    }

    public virtual void DoGuestExitEffect(GuestData guest){

    }

    public virtual void DoExhibitPlaceEffect(){

    }

    public virtual void DoExhibitDestroyEffect(){

    }
}