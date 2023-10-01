using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 
    public HighScoreData highScoreData;

    private int playerScore = 0; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectItem(int itemScoreValue)
    {
        playerScore += itemScoreValue;

        if (playerScore > highScoreData.GetHighScore())
    {
        highScoreData.StoreScore(playerScore); 
    }

    }
}
