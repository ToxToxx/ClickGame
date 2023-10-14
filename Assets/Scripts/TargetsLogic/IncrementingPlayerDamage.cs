using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementingPlayerDamage : MonoBehaviour
{
    [SerializeField] private int damageIncrementor;


    public void IncrementValue()
    {      
        DamageManager.Instance.AdddingPlayerDamage(damageIncrementor);
    }
}

