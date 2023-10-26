public sealed class PlayerHealth : HealthPoints
{  
    public void HealHealth()
    {
        _health += 50;
        if(_health > _maxHealth)
        {
            _maxHealth += 10;
            _health = _maxHealth;
        }
    }
}
