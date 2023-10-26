using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [FormerlySerializedAs("SoundButton")]
    [SerializeField] private Button _soundButton;

    [FormerlySerializedAs("SoundButtonText")]
    [SerializeField] private TextMeshProUGUI _soundButtonText;

    [FormerlySerializedAs("audioClipRefsSO")]
    [SerializeField] private SoundEffectsSO _audioClipRefsSO;


    private bool _isSoundOn = true;
    private float _volume = 1.0f;

    private void Awake()
    {
        _soundButton.onClick.AddListener(() =>
        {
            if (_isSoundOn)
            {
                _volume = 0.0f;
                _soundButtonText.text = "Звуки: выкл";
                _isSoundOn = false;
            }
            else
            {
                _volume = 1f;
                _soundButtonText.text = "Звуки: вкл";
                _isSoundOn = true;
            }
        });
    }
    private void Start()
    {
        DamageManager.Instance.OnIncrementringEnemyDamage += DamageManager_OnIncrementringEnemyDamage;
        DamageManager.Instance.OnIncrementringPlayerDamage += DamageManager_OnIncrementringPlayerDamage;
    }

    private void DamageManager_OnIncrementringPlayerDamage(object sender, System.EventArgs e)
    {
        PlaySound(_audioClipRefsSO.goodTargetSound, transform.position);
    }

    private void DamageManager_OnIncrementringEnemyDamage(object sender, System.EventArgs e)
    {
        PlaySound(_audioClipRefsSO.badTargetSound, transform.position);
    }

    private void PlaySound(AudioClip audioClip, Vector3 position, float volumeMultiplier = 100f)
    {
        AudioSource.PlayClipAtPoint(audioClip, position, volumeMultiplier * _volume);
    }
    private void OnDestroy()
    {
        DamageManager.Instance.OnIncrementringEnemyDamage -= DamageManager_OnIncrementringEnemyDamage;
        DamageManager.Instance.OnIncrementringPlayerDamage -= DamageManager_OnIncrementringPlayerDamage;
    }
}
