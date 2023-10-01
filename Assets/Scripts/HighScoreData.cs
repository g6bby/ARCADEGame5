using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "HighScoreData", menuName = "ScriptableObjects/HighScoreData")]
public class HighScoreData : ScriptableObject
{
    private const string HighScoreKey = "HighScore";

    public int highestScore = 0; 

    public void StoreScore(int newScore)
    {
        if (newScore > highestScore)
        {
            highestScore = newScore;
            PlayerPrefs.SetInt(HighScoreKey, highestScore);
        }
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(HighScoreKey, highestScore);
    }

    public void ClearHighScore()
    {
        highestScore = 0;
        PlayerPrefs.DeleteKey(HighScoreKey);
    }
}
