using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    // 0 for normal mode, 1 for gameover
    private Vector3[] scoreTextPosition = {
        new Vector3(-820, 476, 0),
        new Vector3(-77, 28, 0)
    };

    // 0 for normal mode, 1 for gameover
    private Vector3[] restartButtonPosition = {
        new Vector3(856, 469, 0),
        new Vector3(-13, -125, 0)
    };

    public GameObject scoreText;
    public Transform restartButton;

    public GameObject gameOverCanvas;

    public void GameStart()
    {
        gameOverCanvas.SetActive(false);
        scoreText.transform.localPosition = scoreTextPosition[0];
        scoreText.transform.localScale = new Vector3(1,1,0);
        restartButton.localPosition = restartButtonPosition[0];
        restartButton.localScale = new Vector3(1,1,0);
    }

    public void SetScore(int score) {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + score.ToString();
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        scoreText.transform.localPosition = scoreTextPosition[1];
        scoreText.transform.localScale = new Vector3(1.5f, 1.5f, 0);
        restartButton.localPosition = restartButtonPosition[1];
        restartButton.localScale = new Vector3(2f, 2f, 0); 
    }
} 
