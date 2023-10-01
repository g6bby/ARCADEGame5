using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public HighScoreData highScoreData;

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            //highScoreData.ClearHighScore();
            SceneManager.LoadScene("Start");
        }
    }
}
