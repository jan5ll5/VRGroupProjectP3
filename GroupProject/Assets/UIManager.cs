using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public TextMeshProUGUI scoreText;

    public static int score = 0;
    public static int totalScore = 6;

    void Awake()
    {
        instance = this;
    }

    public static void AddScore(int amount)
    {
        score += amount;
        UIManager.instance.UpdateUI();
    }

   public void UpdateUI()
    {
        scoreText.text = "Score:" + score + "/" + totalScore;
    }
}
