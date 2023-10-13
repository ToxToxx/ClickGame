using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePointsUI : MonoBehaviour
{
    [SerializeField] private DamageManager damageManager;
    [SerializeField] private DamageMultiplierManager damageMultiplierManager;
    [SerializeField] private TextMeshProUGUI enemyDamagePointsText;
    [SerializeField] private TextMeshProUGUI heroDamagePointsText;

    private float heroDamagePoints;
    private float enemyDamagePoints;


    private void Update()
    {
        heroDamagePoints = damageManager.GetPlayerDamage() * damageMultiplierManager.GetDamageMultiplier();
        enemyDamagePoints = damageManager.GetEnemyDamage() + damageMultiplierManager.GetDamageMultiplier() * 2;
        heroDamagePointsText.text = "Урон: " + heroDamagePoints + " (x" + damageMultiplierManager.GetDamageMultiplier() + ")";
        enemyDamagePointsText.text = "Урон: " + enemyDamagePoints + " (+" + (damageMultiplierManager.GetDamageMultiplier() * 2) + ")";
        
    }
}
