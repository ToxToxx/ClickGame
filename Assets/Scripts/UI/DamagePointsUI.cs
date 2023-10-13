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


    private void Update()
    {
        heroDamagePointsText.text = "Урон: " + damageManager.GetPlayerDamage() + " x" + damageMultiplierManager.GetDamageMultiplier();
        enemyDamagePointsText.text = "Урон: " + damageManager.GetEnemyDamage() + " +" + damageMultiplierManager.GetDamageMultiplier();
        
    }
}
