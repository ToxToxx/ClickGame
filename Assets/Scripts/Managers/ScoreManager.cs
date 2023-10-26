using UnityEngine;
using UnityEngine.Serialization;

public class ScoreManager : MonoBehaviour
{
    [FormerlySerializedAs("enemyObject")]
    [SerializeField] private EnemyHealth _enemyObject;

    private float _bestScore;

    void Start()
    {
        LoadBestScore();
    }

    private void Update()
    {
        SetBestScore();
    }

    private void SetBestScore()
    {
        float currentScore = _enemyObject.GetEnemyDeathCounter();
        if (currentScore > _bestScore)
        {
            _bestScore = currentScore;
            SaveBestScore();
        }
    }

    public float GetBestScore()
    {
        return _bestScore;
    }

    private void SaveBestScore()
    {
        PlayerPrefs.SetFloat("BestScore", _bestScore);
    }

    private void LoadBestScore()
    {
        _bestScore = PlayerPrefs.GetFloat("BestScore", 0);
    }
}
