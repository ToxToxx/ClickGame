using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementingValue : MonoBehaviour
{
    [SerializeField] private int DamageIncrementor;

    private void OnDestroy()
    {
        DamageManager.Instance.AddingDamage(DamageIncrementor);
    }
}
