using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [FormerlySerializedAs("audioButton")]
    [SerializeField] private Button _audioButton;

    [FormerlySerializedAs("audioButtonText")]
    [SerializeField] private TextMeshProUGUI _audioButtonText;

    private AudioSource _audioSource;
    private bool _isAudioOn = true;

    private void Awake()
    {  
        _audioSource = GetComponent<AudioSource>();
        _audioButton.onClick.AddListener(() =>
        {
            if(_isAudioOn)
            {
                _audioSource.volume = 0;
                _audioButtonText.text = "Музыка: выкл";
                _isAudioOn = false;
            }
            else 
            {
                _audioSource.volume = 1;
                _audioButtonText.text = "Музыка: вкл";
                _isAudioOn = true;
            }
        });
    }
}
