using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TutorialUI : MonoBehaviour, IUserInterfaceWindow
{
    [FormerlySerializedAs("mainMenuUI")]
    [SerializeField] private GameObject _mainMenuUI;

    [FormerlySerializedAs("tutorialHideButton")]
    [SerializeField] private Button _tutorialHideButton;

    private void Awake()
    {
        _tutorialHideButton.onClick.AddListener(() =>
        {
            Hide();
            _mainMenuUI.GetComponent<MainMenuUI>().Show();
        });
    }
    private void Start()
    {
        Hide();
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
