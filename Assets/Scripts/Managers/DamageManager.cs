using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public static DamageManager Instance;
    [SerializeField] private DamageMultiplierManager damageMultiplierManager;

    [SerializeField] private GameObject enemyGameObject;
    [SerializeField] private GameObject playerGameObject;

    [SerializeField] private int playerDamage;
    [SerializeField] private int enemyDamage;

    private float damageTimer;
    [SerializeField] private float damageTimerMax = 10f;


    private void Awake()
    {
        Instance = this;
           
    }

    private void Start()
    {
        damageTimer = damageTimerMax;
        playerDamage = 0;
        enemyDamage = 0;
        StartCoroutine(DealDamage());
    }
    private void Update()
    {
        damageTimer -= Time.deltaTime;
    }
    public void AdddingPlayerDamage(int incrementor)
    {
        playerDamage += incrementor;
    }
    public void AdddingEnemyDamage(int incrementor)
    {
        enemyDamage += incrementor;
    }

    public void MultiplyPlayerDamage(int multiplier)
    {
        playerDamage *= multiplier;
    }
    IEnumerator DealDamage()
    {
        while(true)
        {
            yield return new WaitForSeconds(damageTimerMax);
            damageTimer = damageTimerMax;

            MultiplyPlayerDamage(damageMultiplierManager.GetDamageMultiplier());

            enemyGameObject.GetComponent<HealthPoints>().TakeDamage(playerDamage);
            playerGameObject.GetComponent<PlayerHealth>().TakeDamage(enemyDamage);  
            
            playerDamage = 0;
            enemyDamage = 0;
            
        }
    }
    public int GetPlayerDamage()
    {
        return playerDamage;
    }
    public int GetEnemyDamage()
    {
        return enemyDamage;
    }

    public float GetAttackTimerNormalized()
    {
        return 1 - (damageTimer / damageTimerMax);
    }
}
