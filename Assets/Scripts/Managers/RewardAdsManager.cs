using UnityEngine;
using YG;
using UnityEngine.Serialization;

public class RewardAdsManager : MonoBehaviour
{
    [FormerlySerializedAs("sdk")]
    [SerializeField] private YandexGame _sdk;

    [FormerlySerializedAs("playerHealth")]
    [SerializeField] private PlayerHealth _playerHealth;

    [FormerlySerializedAs("battleManager")]
    [SerializeField] private BattleManager _battleManager;

    [FormerlySerializedAs("loseScreenUI")]
    [SerializeField] private LoseScreenUI _loseScreenUI;
 
    public void AdButton()
    {
        _sdk._RewardedShow(1);
    }

    public void AdButtonCul()
    {
        _playerHealth.SetHealth(_playerHealth.GetMaxHealth());
        _loseScreenUI.Hide();
        _battleManager.StartTime();
    }
}
