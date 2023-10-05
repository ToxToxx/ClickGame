using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealingPlayerDamage : MonoBehaviour
{
    [SerializeField] private int enemyDamage;

    public void DealPlayerDamage()
    {
        DamageManager.Instance.AdddingEnemyDamage(enemyDamage);
    }
}

