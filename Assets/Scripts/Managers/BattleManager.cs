using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public event EventHandler OnGameWon;
    public event EventHandler OnGameLost;

    [SerializeField] private GameObject playerGameObject;
    [SerializeField] private GameObject enemyGameObject;

    void Start()
    {
        
    }


    void Update()
    {
        GameOver();
    }

    private void GameOver()
    {
        if (playerGameObject.GetComponent<HealthPoints>().GetHealth() <= 0)
        {
            Debug.Log("Враг победил");
            OnGameLost?.Invoke(this, EventArgs.Empty);
            StopTime();
        } else if (enemyGameObject.GetComponent<HealthPoints>().GetHealth() <= 0)
        {
            Debug.Log("Игрок победил");
            OnGameWon?.Invoke(this, EventArgs.Empty);
            StopTime();
        }
    }

    private void StopTime()
    {
        Time.timeScale = 0f;
    }
}
