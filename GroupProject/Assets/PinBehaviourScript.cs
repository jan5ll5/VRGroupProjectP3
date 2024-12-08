using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public static int score;
    int totalScore = 6;

    void OnTrigerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hit_Lane")
        {
            AddScore(1);
        }
        
    }

    void AddScore(int amount)
    {
        score += amount;
        UIManager.instance.UpdateUI(score, totalScore);
    }
}
