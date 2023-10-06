using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonScreenUI : MonoBehaviour
{
    [SerializeField] private BattleManager battleManager;
    void Start()
    {
        Hide();
        battleManager.OnGameWon += BattleManager_OnGameWon; ;
    }

    private void BattleManager_OnGameWon(object sender, System.EventArgs e)
    {
        Show();
    }

    void Update()
    {
        
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
