using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public static DamageManager Instance;
    [SerializeField] private int damage;

    private void Awake()
    {
        Instance = this;
        damage = 0;
    }
    public void AddingDamage(int incrementor)
    {
        damage += incrementor;
    }

    public int GetCurrentDamage()
    {
        return damage;
    }
}
