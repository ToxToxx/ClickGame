using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private EnemyHealth enemyObject;

    private float bestScore;

    void Start()
    {
        LoadBestScore();
    }

    private void Update()
    {
        SetBestScore();
    }

    private void SetBestScore()
    {
        float currentScore = enemyObject.GetEnemyDeathCounter();
        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            SaveBestScore();
        }
    }

    public float GetBestScore()
    {
        return bestScore;
    }

    private void SaveBestScore()
    {
        PlayerPrefs.SetFloat("BestScore", bestScore);
    }

    private void LoadBestScore()
    {
        bestScore = PlayerPrefs.GetFloat("BestScore", 0);
    }
}
