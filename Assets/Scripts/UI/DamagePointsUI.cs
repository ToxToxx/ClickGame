using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class DamagePointsUI : MonoBehaviour
{
    [FormerlySerializedAs("damageManager")]
    [SerializeField] private DamageManager _damageManager;

    [FormerlySerializedAs("damageMultiplierManager")]
    [SerializeField] private DamageMultiplierManager _damageMultiplierManager;

    [FormerlySerializedAs("enemyDamagePointsText")]
    [SerializeField] private TextMeshProUGUI _enemyDamagePointsText;

    [FormerlySerializedAs("heroDamagePointsText")]
    [SerializeField] private TextMeshProUGUI _heroDamagePointsText;

    private float _heroDamagePoints;
    private float _enemyDamagePoints;


    private void Update()
    {
        _heroDamagePoints = _damageManager.GetPlayerDamage() * _damageMultiplierManager.GetDamageMultiplier();
        _enemyDamagePoints = _damageManager.GetEnemyDamage() + _damageMultiplierManager.GetDamageMultiplier() * 2;
        _heroDamagePointsText.text = "Урон: " + _heroDamagePoints + " (x" + _damageMultiplierManager.GetDamageMultiplier() + ")";
        _enemyDamagePointsText.text = "Урон: " + _enemyDamagePoints + " (+" + (_damageMultiplierManager.GetDamageMultiplier() * 2) + ")";
        
    }
}
