using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ResumeButtonUI : MonoBehaviour
{
    [FormerlySerializedAs("pauseUI")]
    [SerializeField] private PauseUI _pauseUI;

    [FormerlySerializedAs("resumeButtonUI")]
    [SerializeField] private Button _resumeButtonUI;
    private void Awake()
    {
        _resumeButtonUI.onClick.AddListener(() =>
        {
            Time.timeScale = 1.0f;
            _pauseUI.Hide();
        });
    }
}
