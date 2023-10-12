using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public event EventHandler OnGameWon;
    public event EventHandler OnGameLost;
    
    private int WonCounter;


    [SerializeField] private GameObject playerGameObject;
    [SerializeField] private GameObject enemyGameObject;
    private void Awake()
    {
        StartTime();
        WonCounter = enemyGameObject.GetComponent<EnemyHealth>().GetEnemyDeathCounter();
    }
    void Update()
    {
        GameOver();
    }

    private void GameOver()
    {
        if (playerGameObject.GetComponent<HealthPoints>().GetHealth() <= 0)
        {
            OnGameLost?.Invoke(this, EventArgs.Empty);
            StopTime();
        } else if (enemyGameObject.GetComponent<EnemyHealth>().GetEnemyDeathCounter() != WonCounter)
        {
            PlayerHealth.Instance.HealHealth();
            WonCounter = enemyGameObject.GetComponent<EnemyHealth>().GetEnemyDeathCounter();
           // OnGameWon?.Invoke(this, EventArgs.Empty);
            //StopTime();
        }
    }

    private void StopTime()
    {
        Time.timeScale = 0f;
    }
    private void StartTime()
    {
        Time.timeScale = 1f;
    }
}
