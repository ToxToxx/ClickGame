using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthPoints
{
    private int enemyDeathCounter;
    [SerializeField] private int healthTreshold = 100;
    [SerializeField] private int healthMultiplier = 2;
    [SerializeField] private int healthAdder = 10;

    private void Start()
    {
        enemyDeathCounter = 0;
    }
    private void Update()
    {
        IncreaseHealth();
    }

    private void IncreaseHealth()
    {
        if(health <= 0)
        {
            enemyDeathCounter++;
            if(maxHealth < healthTreshold)
            {
                maxHealth = maxHealth * healthMultiplier;
            }
            else
            {
                maxHealth += healthAdder;
            }
            
            health = maxHealth;
        }
    }

    public int GetEnemyDeathCounter()
    {
        return enemyDeathCounter;
    }
}
