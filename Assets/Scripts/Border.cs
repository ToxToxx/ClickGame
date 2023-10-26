using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;

    [SerializeField] private int looseObjectDamage;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        if (other.gameObject.GetComponent<IncrementingPlayerDamage>())
        {
            _playerHealth.TakeDamage(looseObjectDamage);
        }
    }


}
