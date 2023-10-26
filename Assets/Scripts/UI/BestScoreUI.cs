using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class BestScoreUI : MonoBehaviour
{
    [FormerlySerializedAs("scoreManager")]
    [SerializeField] private ScoreManager _scoreManager;

    [FormerlySerializedAs("bestScoreText")]
    [SerializeField] private TextMeshProUGUI _bestScoreText;

    void Update()
    {        
        _bestScoreText.text = "Рекорд: " + _scoreManager.GetBestScore();
    }       
}
