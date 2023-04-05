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

    int score = 0;
    int streak = 0;
    public void IncreaseScore()
    {
        //incrament streak
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
    }
}
