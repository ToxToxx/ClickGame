using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyDeathScoreUI : MonoBehaviour
{
    [FormerlySerializedAs("enemyObject")]
    [SerializeField] private EnemyHealth _enemyObject;

    [FormerlySerializedAs("enemyDeathText")]
    [SerializeField] private TextMeshProUGUI _enemyDeathText;

    private void Update()
    {
        _enemyDeathText.text = "Побеждено: " + _enemyObject.GetEnemyDeathCounter();
    }
}
