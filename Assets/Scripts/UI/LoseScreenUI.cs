using UnityEngine;
using UnityEngine.Serialization;

public class LoseScreenUI : MonoBehaviour, IUserInterfaceWindow
{
    [FormerlySerializedAs("battleManager")]
    [SerializeField] private BattleManager _battleManager;

    void Start()
    {
        Hide();
        _battleManager.OnGameLost += BattleManager_OnGameLost;
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
