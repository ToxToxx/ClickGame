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


    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);

    }
}
