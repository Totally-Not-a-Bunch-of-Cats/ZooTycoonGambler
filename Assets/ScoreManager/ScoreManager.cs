using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;

    public void AddToScore(int score){
        this.score += score;
    }
}
