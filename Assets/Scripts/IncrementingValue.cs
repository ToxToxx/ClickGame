using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementingValue : MonoBehaviour
{
    [SerializeField] private int DamageIncrementor;

    public void IncrementValue()
    {
        DamageManager.Instance.AddingDamage(DamageIncrementor);
    }
}
