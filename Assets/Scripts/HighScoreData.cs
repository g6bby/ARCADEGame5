using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HighScoreData", menuName = "ScriptableObjects/HighScoreData")]
public class HighScoreData : ScriptableObject
{
    public int highestScore = 0;

    public void StoreScore(int newScore)
    {
    
        if (newScore > highestScore)
        {
            highestScore = newScore;
        }
    }

    public int GetHighScore()
    {
        return highestScore;
    }
}
