using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private Button audioButton;
    [SerializeField] private TextMeshProUGUI audioButtonText;
    private AudioSource audioSource;
    private bool isAudioOn = true;
    private void Awake()
    {  
        audioSource = GetComponent<AudioSource>();
        audioButton.onClick.AddListener(() =>
        {
            if(isAudioOn)
            {
                audioSource.volume = 0;
                audioButtonText.text = "«вук: выкл";
                isAudioOn = false;
            }
            else 
            {
                audioSource.volume = 1;
                audioButtonText.text = "«вук: вкл";
            }
        });
    }
}
