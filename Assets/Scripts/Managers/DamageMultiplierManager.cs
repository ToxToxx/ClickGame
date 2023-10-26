using UnityEngine;
using UnityEngine.Serialization;

public class DamageMultiplierManager : MonoBehaviour
{
    [FormerlySerializedAs("damageMultiplier")]
    [SerializeField] private int _damageMultiplier;

    [FormerlySerializedAs("enemyDefeated")]
    [SerializeField] private int _enemyDefeatedCoef = 3;

    [FormerlySerializedAs("enemyObject")]
    [SerializeField] private EnemyHealth _enemyObject;

    private int _lastDeathCount = 0;
    private int _increaseAmount;

    private void Start()
    {
        _damageMultiplier = 1;
        _lastDeathCount = _enemyObject.GetEnemyDeathCounter();
    }

    private void Update()
    {
        int currentDeathCount = _enemyObject.GetEnemyDeathCounter();
        int deathsSinceLastUpdate = currentDeathCount - _lastDeathCount;

        if (deathsSinceLastUpdate >= _enemyDefeatedCoef)
        {
            _increaseAmount = deathsSinceLastUpdate / _enemyDefeatedCoef;
            _damageMultiplier += _increaseAmount;

            _lastDeathCount = currentDeathCount;
        }
    }

    public int GetDamageMultiplier()
    {
        return _damageMultiplier;
    }
}
