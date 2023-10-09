using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePointsUI : MonoBehaviour
{
    [SerializeField] private DamageManager damageManager;
    [SerializeField] private TextMeshProUGUI enemyDamagePointsText;
    [SerializeField] private TextMeshProUGUI heroDamagePointsText;


    private void Update()
    {
        heroDamagePointsText.text = "����: " + damageManager.GetPlayerDamage();
        enemyDamagePointsText.text = "����: " + damageManager.GetEnemyDamage();
        
    }
}
