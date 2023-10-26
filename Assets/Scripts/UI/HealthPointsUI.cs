using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class HealthPointsUI : MonoBehaviour
{
    [FormerlySerializedAs("healthPointsText")]
    [SerializeField] private TextMeshProUGUI _healthPointsText;

    [FormerlySerializedAs("heroHealthObject")]
    [SerializeField] private GameObject _heroHealthObject;

    private void Update()
    {
        _healthPointsText.text = "Çהמנמגüו: " + Convert.ToString(_heroHealthObject.GetComponent<HealthPoints>().GetHealth());
    }
}
