using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthPoints
{
    private int enemyDeathCounter;

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
            maxHealth = maxHealth * 2;
            health = maxHealth;
        }
    }

    public int GetEnemyDeathCounter()
    {
        return enemyDeathCounter;
    }
}
