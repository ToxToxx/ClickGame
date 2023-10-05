using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthPoints
{
    public static PlayerHealth Instance;

    private void Awake()
    {
        Instance = this;
    }
}
