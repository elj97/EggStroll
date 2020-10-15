using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;
    public TextMeshProUGUI finalScoreText;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "Score " + score.ToString();
    }

    private void Update()
    {
        if (finalScoreText !== null)
        {
            finalScoreText.text = score.ToString();
        }
    }
}
