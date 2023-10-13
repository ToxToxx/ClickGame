using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMultiplierManager : MonoBehaviour
{
    [SerializeField] private int damageMultiplier;
    [SerializeField] private int enemyDefeated = 3;
    [SerializeField] private EnemyHealth enemyObject;
    private int lastDeathCount = 0;

    private void Start()
    {
        damageMultiplier = 1;
        lastDeathCount = enemyObject.GetEnemyDeathCounter();
    }

    private void Update()
    {
        int currentDeathCount = enemyObject.GetEnemyDeathCounter();
        int deathsSinceLastUpdate = currentDeathCount - lastDeathCount;

        if (deathsSinceLastUpdate >= enemyDefeated)
        {
            int increaseAmount = deathsSinceLastUpdate / enemyDefeated;
            damageMultiplier += increaseAmount;
            lastDeathCount = currentDeathCount;
        }
    }

    public int GetDamageMultiplier()
    {
        return damageMultiplier;
    }
}
