using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpellUI : MonoBehaviour
{
    [SerializeField] private GameObject enemySpell;
    private float timer;

    void Start()
    {        
        HideSpellUI();
     
    }
    private void Update()
    {
        ShowWorkingSpell();
    }

    private void HideSpellUI()
    {
        gameObject.SetActive(false);
    }
    private void ShowSpellUI()
    {
        gameObject.SetActive(true);
    }
    private void ShowWorkingSpell()
    {
        if (timer >= enemySpell.GetComponent<GrabAndDealSpell>().GetSpellCooldown()) 
        {
            ShowSpellUI();
        } else
        {
            HideSpellUI();
            timer += Time.deltaTime;
        }
        
    }
}
