﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 2);
    }
}