using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public GameObject ScoreText;
    public GameObject StreakText;
    public GameObject ProgressBar;
    public GameObject LivesCounter;

    int score = 0;
    int streak = 0;
    int lives = 7;
    public void IncreaseScore()
    {
        //increment score
        score++;
        streak++;

        //update score display
        ScoreText.GetComponent<TextMeshPro>().text = score.ToString();
        StreakText.GetComponent<TextMeshPro>().text = streak.ToString();

        //progress bar position
        ProgressBar.transform.position = new Vector2(((float)Mathf.Clamp(score, 0, 50) / 50 * 14) - 14, 3.25f);
    }

    public void ResetStreak()
    {
        //reset streak
        streak = 0;

        //update score display
        StreakText.GetComponent<TextMeshPro>().text = streak.ToString();

        //life counter position
        lives--;
        LivesCounter.transform.position = new Vector2(-1.625f, ((float)Mathf.Clamp(lives, 0, 7) * 0.375f) -  1.125f);

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        print("GameOver");
    }
}
