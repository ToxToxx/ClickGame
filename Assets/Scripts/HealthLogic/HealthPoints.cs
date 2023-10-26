using UnityEngine;
using UnityEngine.Serialization;

public class HealthPoints : MonoBehaviour
{
    [FormerlySerializedAs("health")]
    [SerializeField] protected int _health;

    [FormerlySerializedAs("maxHealth")]
    [SerializeField] protected int _maxHealth;

    private void Start()
    {
        _health = _maxHealth;
    }
    private void Update()
    {
        if (_health <= 0)
        {
            _health = 0;
        }
    }
    public void TakeDamage(int damageAmount)
    {         
        _health -= damageAmount;
    }

    public int GetHealth() 
    { 
        return _health;
    }

    public void SetHealth(int healthAmount)
    {
        _health = healthAmount;
    }
    public int GetMaxHealth()
    {
        return _maxHealth;
    }

}
