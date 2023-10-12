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
            if(maxHealth < 100)
            {
                maxHealth = maxHealth * 2;
            }
            else
            {
                maxHealth += 10;
            }
            
            health = maxHealth;
        }
    }

    public int GetEnemyDeathCounter()
    {
        return enemyDeathCounter;
    }
}
