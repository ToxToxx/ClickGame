using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private float bestScore;

    [SerializeField] private EnemyHealth enemyObject;
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
    }
}
