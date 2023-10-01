using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public HighScoreData highScoreData;

    private void Start()
    {
        int currentHighScore = highScoreData.GetHighScore();
        highScoreText.text = $"High Score: {currentHighScore}";
    }
}
