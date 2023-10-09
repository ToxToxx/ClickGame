using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public static DamageManager Instance;

    [SerializeField] private GameObject enemyGameObject;
    [SerializeField] private GameObject playerGameObject;

    [SerializeField] private int playerDamage;
    [SerializeField] private int enemyDamage;

    [SerializeField] private float damageTimer = 3.0f;

    private void Awake()
    {
        Instance = this;
        playerDamage = 0;
    }

    private void Start()
    {
        StartCoroutine(DealDamage());
    }
    public void AdddingPlayerDamage(int incrementor)
    {
        playerDamage += incrementor;
    }
    public void AdddingEnemyDamage(int incrementor)
    {
        enemyDamage += incrementor;
    }

    public int GetCurrentPlayerDamage()
    {
        return playerDamage;
    }

    IEnumerator DealDamage()
    {
        while(true)
        {
            yield return new WaitForSeconds(damageTimer);
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
}
