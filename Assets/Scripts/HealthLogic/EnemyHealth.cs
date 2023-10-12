using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthPoints
{
    private void Update()
    {
        IncreaseHealth();
    }

    private void IncreaseHealth()
    {
        if(health <= 0)
        {
            maxHealth = maxHealth * 2;
            health = maxHealth;
        }
    }
}
