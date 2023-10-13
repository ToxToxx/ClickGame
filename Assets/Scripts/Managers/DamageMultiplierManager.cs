using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMultiplierManager : MonoBehaviour
{
    [SerializeField] private int damageMultiplier;
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

        if (deathsSinceLastUpdate >= 3)
        {
            int increaseAmount = deathsSinceLastUpdate / 3;
            damageMultiplier += increaseAmount;
            lastDeathCount = currentDeathCount;
        }
    }

    public int GetDamageMultiplier()
    {
        return damageMultiplier;
    }
}
