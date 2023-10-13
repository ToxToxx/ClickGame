using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BestScoreUI : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TextMeshProUGUI bestScoreText;

    void Update()
    {        
        bestScoreText.text = "Рекорд: " + scoreManager.GetBestScore();
    }       
}
