using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScreenUI : MonoBehaviour
{
    [SerializeField] private BattleManager battleManager;
    void Start()
    {
        Hide();
        battleManager.OnGameLost += BattleManager_OnGameLost;
    }

    private void BattleManager_OnGameLost(object sender, System.EventArgs e)
    {
        Show();
    }


    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);

    }
}
