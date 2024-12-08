using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text scoreText;
    public static int score = 0;
    public static int totalScore = 6;

   public void UpdateUI(int score, int totalScore)
    {
        scoreText.text = "Score:" + score + "/" + totalScore;
    }
}
