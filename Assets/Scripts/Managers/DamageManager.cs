using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class DamageManager : MonoBehaviour
{
    public event EventHandler OnIncrementringPlayerDamage;
    public event EventHandler OnIncrementringEnemyDamage;

    public static DamageManager Instance;

    [FormerlySerializedAs("damageMultiplierManager")]
    [SerializeField] private DamageMultiplierManager _damageMultiplierManager;

    [FormerlySerializedAs("enemyGameObject")]
    [SerializeField] private GameObject _enemyGameObject;

    [FormerlySerializedAs("playerGameObject")]
    [SerializeField] private GameObject _playerGameObject;

    [SerializeField] private int _playerDamage;
    [SerializeField] private int _enemyDamage;

    private readonly float _damageTimerMax = 10f;
    private float _damageTimer;

    private void Awake()
    {
        Instance = this;
           
    }

    private void Start()
    {
        _damageTimer = _damageTimerMax;
        _playerDamage = 0;
        _enemyDamage = 0;
        StartCoroutine(DealDamage());
    }
    private void Update()
    {
        _damageTimer -= Time.deltaTime;
    }
    public void AdddingPlayerDamage(int incrementor)
    {
        _playerDamage += incrementor;
        OnIncrementringPlayerDamage?.Invoke(this, EventArgs.Empty);
    }
    public void AdddingEnemyDamage(int incrementor)
    {
        _enemyDamage += incrementor;
        OnIncrementringEnemyDamage?.Invoke(this,EventArgs.Empty);
    }

    public void MultiplyDamage(int multiplier)
    {
        _playerDamage *= multiplier;
        _enemyDamage += multiplier * 2;
    }
    IEnumerator DealDamage()
    {
        while(true)
        {
            yield return new WaitForSeconds(_damageTimerMax);
            _damageTimer = _damageTimerMax;

            MultiplyDamage(_damageMultiplierManager.GetDamageMultiplier());

            _enemyGameObject.GetComponent<HealthPoints>().TakeDamage(_playerDamage);
            _playerGameObject.GetComponent<PlayerHealth>().TakeDamage(_enemyDamage);  
            
            _playerDamage = 0;
            _enemyDamage = 0;
            
        }
    }
    public int GetPlayerDamage()
    {
        return _playerDamage;
    }
    public int GetEnemyDamage()
    {
        return _enemyDamage;
    }

    public float GetAttackTimerNormalized()
    {
        return 1 - (_damageTimer / _damageTimerMax);
    }
}
