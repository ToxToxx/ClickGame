using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabAndDealSpell : MonoBehaviour
{
    private int objectsIncrement;
    [SerializeField] private float spellCooldown;
    [SerializeField] private int damageOfSpell;
    private float timerOfSpell;

    void Start()
    {
        objectsIncrement = 0;
        StartCoroutine(GrabAndDeal());
    }
    private void Update()
    {
        timerOfSpell -= Time.deltaTime;
    }

    IEnumerator GrabAndDeal()
    {
        while (true)
        {
            yield return new WaitForSeconds(spellCooldown);
            try
            {         
                DealingPlayerDamage[] objectsToDestroy = FindObjectsOfType<DealingPlayerDamage>();
                foreach (DealingPlayerDamage obj in objectsToDestroy)
                {
                    Destroy(obj.gameObject);
                    objectsIncrement++;
                }              
            }
            catch
            {

            }
            timerOfSpell = spellCooldown;
            DamageManager.Instance.AdddingEnemyDamage(damageOfSpell * objectsIncrement);
            objectsIncrement = 0;
        }
        
    }

    public float GetSpellCooldown()
    {
        return spellCooldown;
    }
    public float GetAttackTimerNormalized()
    {
        return 1 - (timerOfSpell / spellCooldown);
    }
}
