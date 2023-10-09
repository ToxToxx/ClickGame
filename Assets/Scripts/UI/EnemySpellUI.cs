using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemySpellUI : MonoBehaviour
{
    [SerializeField] private GameObject enemySpell;
    [SerializeField] private TextMeshProUGUI enemySpellText;
    private float timer = 0;
    private float maxTimer;

    void Start()
    {
        maxTimer = enemySpell.GetComponent<GrabAndDealSpell>().GetSpellCooldown();
        HideSpellUI();
        StartCoroutine(ShowWorkingSpell());
    }
    private void Update()
    {
        if( timer < 0)
        {
            HideSpellUI();
        }
        timer -= Time.deltaTime * 2;
    }

    private void HideSpellUI()
    {
        enemySpellText.text = " ";
    }
    private void ShowSpellUI()
    {
        enemySpellText.text = "ÕÂÀÒÀÉ";
    }
    IEnumerator ShowWorkingSpell()
    {
        yield return new WaitForSeconds(enemySpell.GetComponent<GrabAndDealSpell>().GetSpellCooldown());
        ShowSpellUI();
        timer = maxTimer;
    }
}
