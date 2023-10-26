using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class GrabAndDealSpell : MonoBehaviour
{
    [FormerlySerializedAs("spellCooldown")]
    [SerializeField] private float _spellCooldown;

    [FormerlySerializedAs("damageOfSpell")]
    [SerializeField] private int _damageOfSpell;

    private int _objectsIncrement;
    private float _timerOfSpell;

    void Start()
    {
        _objectsIncrement = 0;
        StartCoroutine(GrabAndDeal());
    }
    private void Update()
    {
        _timerOfSpell -= Time.deltaTime;
    }

    IEnumerator GrabAndDeal()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spellCooldown);
            try
            {         
                DealingPlayerDamage[] objectsToDestroy = FindObjectsOfType<DealingPlayerDamage>();
                foreach (DealingPlayerDamage obj in objectsToDestroy)
                {
                    Destroy(obj.gameObject);
                    _objectsIncrement++;
                }              
            }
            catch
            {

            }
            _timerOfSpell = _spellCooldown;
            DamageManager.Instance.AdddingEnemyDamage(_damageOfSpell * _objectsIncrement);
            _objectsIncrement = 0;
        }
        
    }

    public float GetSpellCooldown()
    {
        return _spellCooldown;
    }
    public float GetAttackTimerNormalized()
    {
        return 1 - (_timerOfSpell / _spellCooldown);
    }
}
