using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthPoints
{  
    public static PlayerHealth Instance;

    private void Awake()
    {
        Instance = this;
    }
    

    public void HealHealth()
    {
        health += 50;
        if(health > maxHealth)
        {
            maxHealth += 10;
            health = maxHealth;
        }
    }
}
