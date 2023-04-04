using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject streakText;

    int score = 0;
    int streak = 0;

    void Start()
    {
        
    }
 
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score++;
        streak++;

        scoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
        streakText.GetComponent<TextMeshProUGUI>().text = streak.ToString();
    }

    public void ResetStreak()
    {
        streak = 0;

        streakText.GetComponent<TextMeshProUGUI>().text = streak.ToString();
    }
}
