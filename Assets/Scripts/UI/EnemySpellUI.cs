using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemySpellUI : MonoBehaviour
{
    [SerializeField] private GameObject enemySpell;
    [SerializeField] private TextMeshProUGUI enemySpellText;
    private float timerRange = 0.9f;

    void Start()
    {
        HideSpellUI();
    }

    private void Update()
    {
        if(enemySpell.GetComponent<GrabAndDealSpell>().GetAttackTimerNormalized() > timerRange)
        {
            ShowSpellUI();
        }
        else
        {
            HideSpellUI();
        }
    }
    private void HideSpellUI()
    {
        enemySpellText.text = " ";
    }
    private void ShowSpellUI()
    {
        enemySpellText.text = "’¬¿“¿…";
    }

}
