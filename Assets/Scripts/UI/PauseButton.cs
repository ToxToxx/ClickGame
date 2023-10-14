using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private PauseUI pauseUI;
    [SerializeField] private Button pauseButtonUI;
    private void Awake()
    {
        pauseButtonUI.onClick.AddListener(() =>
        {
            Time.timeScale = 0.0f;
            pauseUI.Show();
        });
    }
}
