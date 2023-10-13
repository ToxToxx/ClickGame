using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BestScoreUI : MonoBehaviour
{
    [SerializeField] private float bestScore;

    [SerializeField] private EnemyHealth enemyObject;
    [SerializeField] private TextMeshProUGUI bestScoreText;

    void Start()
    {      
        bestScore = PlayerPrefs.GetInt("BestScore", 0);       
    }


    void Update()
    {
        SetBestScore();
        bestScoreText.text = "Рекорд: " + bestScore;
    }
    public void SetBestScore()
    {
        float maxScore = enemyObject.GetEnemyDeathCounter();
        if (maxScore > bestScore)
        {
            bestScore = maxScore;
            PlayerPrefs.SetFloat("BestScore", bestScore);
        }
    }
    public float GetBestScore()
    {
        return bestScore;
    }
}
