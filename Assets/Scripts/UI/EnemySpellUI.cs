using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemySpellUI : MonoBehaviour
{
    [FormerlySerializedAs("enemySpell")]
    [SerializeField] private GameObject _enemySpell;

    [FormerlySerializedAs("enemySpellText")]
    [SerializeField] private TextMeshProUGUI _enemySpellText;

    private readonly float timerRange = 0.9f;

    void Start()
    {
        HideSpellUI();
    }

    private void Update()
    {
        if(_enemySpell.GetComponent<GrabAndDealSpell>().GetAttackTimerNormalized() > timerRange)
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
        _enemySpellText.text = " ";
    }
    private void ShowSpellUI()
    {
        _enemySpellText.text = "’¬¿“¿…";
    }

}
