using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour, IUserInterfaceWindow
{
    public static MainMenuUI Instance;

    [FormerlySerializedAs("tutorialUI")]
    [SerializeField] private GameObject _tutorialUI;

    [FormerlySerializedAs("playButton")]
    [SerializeField] private Button _playButton;

    [FormerlySerializedAs("tutorialButton")]
    [SerializeField] private Button _tutorialButton;

    private void Awake()
    {
        _playButton.onClick.AddListener(() =>
        {
            Hide();
            Loader.Load(Loader.Scene.GameScene);
        });
        _tutorialButton.onClick.AddListener(() =>
        {
            Hide();
            _tutorialUI.GetComponent<TutorialUI>().Show();
        });
        Time.timeScale = 1.0f;
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
