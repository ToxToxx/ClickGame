using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthPointsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthPointsText;
    [SerializeField] private GameObject heroHealthObject;

    private void Update()
    {
        healthPointsText.text = "Çהמנמגüו: " + Convert.ToString(heroHealthObject.GetComponent<HealthPoints>().GetHealth());
    }



}
