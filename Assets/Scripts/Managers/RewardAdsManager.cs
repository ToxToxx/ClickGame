using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using UnityEngine.UI;

public class RewardAdsManager : MonoBehaviour
{
    [SerializeField] private YandexGame sdk;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private BattleManager battleManager;
    [SerializeField] private LoseScreenUI loseScreenUI;
 
    public void AdButton()
    {
        sdk._RewardedShow(1);
    }

    public void AdButtonCul()
    {
        playerHealth.SetHealth(playerHealth.GetMaxHealth());
        loseScreenUI.Hide();
        battleManager.StartTime();
    }
}
