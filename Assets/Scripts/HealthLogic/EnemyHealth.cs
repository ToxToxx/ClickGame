using UnityEngine;
using UnityEngine.Serialization;

public sealed class EnemyHealth : HealthPoints
{
    private int _enemyDeathCounter;

    [FormerlySerializedAs("healthTreshold")]
    [SerializeField] private int _healthTreshold = 100;

    [FormerlySerializedAs("healthMultiplier")]
    [SerializeField] private int _healthMultiplier = 2;

    [FormerlySerializedAs("healthAdder")] 
    [SerializeField] private int _healthAdder = 10;

    private void Start()
    {
        _enemyDeathCounter = 0;
    }
    private void Update()
    {
        IncreaseHealth();
    }

    private void IncreaseHealth()
    {
        if(_health <= 0)
        {
            _enemyDeathCounter++;
            if(_maxHealth < _healthTreshold)
            {
                _maxHealth *= _healthMultiplier;
            }
            else
            {
                _maxHealth += _healthAdder;
            }
            
            _health = _maxHealth;
        }
    }

    public int GetEnemyDeathCounter()
    {
        return _enemyDeathCounter;
    }
}
