using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameManager gameManager;

    private void Start()
    {
        UpdateScoreText();
    }

    private void Update()
    {
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        int currentScore = gameManager.GetScore();

        scoreText.text = "Score: " + currentScore.ToString() + "/ 10";

        int highScore = gameManager.highScoreData.GetHighScore();

        highScoreText.text = "High Score: " + highScore.ToString();
    }
}
