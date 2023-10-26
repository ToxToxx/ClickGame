using UnityEngine;
using UnityEngine.Serialization;

public class DealingPlayerDamage : MonoBehaviour
{
    [FormerlySerializedAs("enemyDamage")]
    [SerializeField] private int _enemyDamage;

    public void DealPlayerDamage()
    {
        DamageManager.Instance.AdddingEnemyDamage(_enemyDamage);
    }
}

