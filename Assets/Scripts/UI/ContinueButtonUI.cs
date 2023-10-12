using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButtonUI : MonoBehaviour
{
    [SerializeField] private Button continueButton;
    [SerializeField] private GameObject wonScreenUI;

    private void Awake()
    {
        continueButton.onClick.AddListener(() =>
        {
            Time.timeScale = 1.0f;
            wonScreenUI.SetActive(false);
        });

    }
}
