using System;
using UnityEngine;
using UnityEngine.Serialization;

public class BattleManager : MonoBehaviour
{
    public event EventHandler OnGameLost;
    
    private int _wonCounter;

    [SerializeField] private PlayerHealth _playerHealth;

    [FormerlySerializedAs("playerGameObject")]
    [SerializeField] private GameObject _playerGameObject;

    [FormerlySerializedAs("enemyGameObject")]
    [SerializeField] private GameObject _enemyGameObject;

    private void Awake()
    {
        StartTime();
        _wonCounter = _enemyGameObject.GetComponent<EnemyHealth>().GetEnemyDeathCounter();
    }
    void Update()
    {
        GameOver();
    }

    private void GameOver()
    {
        if (_playerGameObject.GetComponent<HealthPoints>().GetHealth() <= 0)
        {
            OnGameLost?.Invoke(this, EventArgs.Empty);
            StopTime();
        } else if (_enemyGameObject.GetComponent<EnemyHealth>().GetEnemyDeathCounter() != _wonCounter)
        {
            _playerHealth.HealHealth();
            _wonCounter = _enemyGameObject.GetComponent<EnemyHealth>().GetEnemyDeathCounter();
        }
    }

    private void StopTime()
    {
        Time.timeScale = 0f;
    }
    public void StartTime()
    {
        Time.timeScale = 1f;
    }
}
