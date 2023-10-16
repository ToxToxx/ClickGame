using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] protected int health;
    [SerializeField] protected int maxHealth;

    private void Start()
    {
        health = maxHealth;
    }
    private void Update()
    {
        if (health <= 0)
        {
            health = 0;
        }
    }
    public void TakeDamage(int damageAmount)
    {         
        health -= damageAmount;
    }

    public int GetHealth() 
    { 
        return health;
    }

    public void SetHealth(int healthAmount)
    {
        health = healthAmount;
    }
    public int GetMaxHealth()
    {
        return maxHealth;
    }

}
