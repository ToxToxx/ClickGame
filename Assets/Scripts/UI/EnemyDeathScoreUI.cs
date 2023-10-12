using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyDeathScoreUI : MonoBehaviour
{
    [SerializeField] private EnemyHealth enemyObject;
    [SerializeField] private TextMeshProUGUI enemyDeathText;

    private void Update()
    {
        enemyDeathText.text = "Побеждено: " + enemyObject.GetEnemyDeathCounter();
    }
}
