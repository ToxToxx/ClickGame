using UnityEngine;
using UnityEngine.Serialization;

public class IncrementingPlayerDamage : MonoBehaviour
{
    [FormerlySerializedAs("damageIncrementor")]
    [SerializeField] private int _damageIncrementor;


    public void IncrementValue()
    {      
        DamageManager.Instance.AdddingPlayerDamage(_damageIncrementor);
    }
}

