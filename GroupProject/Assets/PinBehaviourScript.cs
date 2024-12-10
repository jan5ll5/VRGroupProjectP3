using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /*
    public static int score;
    int totalScore = 6;
    */
    void OnTrigerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hite_Lane")
        {
            UIManager.AddScore(1);
            Destroy(gameObject, 1.5f);
        }
        
    }
    /*
    void AddScore(int amount)
    {
        score += amount;
        UIManager.instance.UpdateUI(score, totalScore);
    }
    */
}
