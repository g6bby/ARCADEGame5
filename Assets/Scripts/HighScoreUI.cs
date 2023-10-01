using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreUI : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public HighScoreData highScoreData;

    private void Start()
    {
        UpdateHighScoreText();
    }

    public void UpdateHighScoreText()
    {
        int highestScore = highScoreData.GetHighScore();
        highScoreText.text = $"High Score: {highestScore}/10";
    }
}
