using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButtonUI : MonoBehaviour
{
    [SerializeField] private PauseUI pauseUI;
    [SerializeField] private Button resumeButtonUI;
    private void Awake()
    {
        resumeButtonUI.onClick.AddListener(() =>
        {
            Time.timeScale = 1.0f;
            pauseUI.Hide();
        });
    }

}
