using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [FormerlySerializedAs("pauseUI")]
    [SerializeField] private PauseUI _pauseUI;

    [FormerlySerializedAs("pauseButtonUI")]
    [SerializeField] private Button _pauseButtonUI;

    private void Awake()
    {
        _pauseButtonUI.onClick.AddListener(() =>
        {
            Time.timeScale = 0.0f;
            _pauseUI.Show();
        });
    }
}
