using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitManager : MonoBehaviour
{
    List<ExhibitEffect> exhibits;

    public void AddExhibit(ExhibitEffect exhibit){
        exhibits.Add(exhibit);
    }
}
