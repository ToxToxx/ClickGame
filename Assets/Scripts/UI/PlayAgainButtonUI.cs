using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PlayAgainButtonUI : MonoBehaviour
{
    [FormerlySerializedAs("playAgainButton")]
    [SerializeField] private Button _playAgainButton;

    private void Awake()
    {
        _playAgainButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.GameScene);
        });

    }
}
