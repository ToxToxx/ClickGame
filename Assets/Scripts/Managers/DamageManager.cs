using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public static DamageManager Instance;
    [SerializeField] private GameObject enemyGameObject;
    [SerializeField] private int damage;
    [SerializeField] private float damageTimer = 3.0f;

    private void Awake()
    {
        Instance = this;
        damage = 0;
    }

    private void Start()
    {
        StartCoroutine(DealDamage());
    }
    public void AddingDamage(int incrementor)
    {
        damage += incrementor;
    }

    public int GetCurrentDamage()
    {
        return damage;
    }

    IEnumerator DealDamage()
    {
        while(true)
        {
            yield return new WaitForSeconds(damageTimer);
            enemyGameObject.GetComponent<HealthPoints>().TakeDamage(damage);
            damage = 0;
        }
    }
}
