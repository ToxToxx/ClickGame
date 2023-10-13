using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialUI : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private Button tutorialHideButton;

    private void Awake()
    {
        tutorialHideButton.onClick.AddListener(() =>
        {
            HideTutorial();
            mainMenuUI.GetComponent<MainMenuUI>().ShowMainMenu();
        });
    }
    private void Start()
    {
        HideTutorial();
    }

    public void ShowTutorial()
    {
        gameObject.SetActive(true);
    }

    public void HideTutorial()
    {
        gameObject.SetActive(false);
    }
}
