using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementingValue : MonoBehaviour
{
    [SerializeField] private int damageIncrementor;

    public void IncrementValue()
    {
        DamageManager.Instance.AdddingPlayerDamage(damageIncrementor);
    }
}
