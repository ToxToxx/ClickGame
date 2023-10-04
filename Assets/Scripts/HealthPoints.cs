using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] private int health;

    [SerializeField] private int maxHealth;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
    }

    public int GetHealth() 
    { 
        return health;
    }
}
