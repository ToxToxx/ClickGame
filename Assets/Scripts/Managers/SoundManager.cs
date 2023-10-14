using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Button SoundButton;
    [SerializeField] private TextMeshProUGUI SoundButtonText;
    [SerializeField] private SoundEffectsSO audioClipRefsSO;


    private bool isSoundOn = true;
    private float volume = 1.0f;
    private void Awake()
    {
        SoundButton.onClick.AddListener(() =>
        {
            if (isSoundOn)
            {
                volume = 0.0f;
                SoundButtonText.text = "Звуки: выкл";
                isSoundOn = false;
            }
            else
            {
                volume = 1f;
                SoundButtonText.text = "Звуки: вкл";
                isSoundOn = true;
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
        PlaySound(audioClipRefsSO.goodTargetSound, transform.position);
    }

    private void DamageManager_OnIncrementringEnemyDamage(object sender, System.EventArgs e)
    {
        PlaySound(audioClipRefsSO.badTargetSound, transform.position);
    }

    private void PlaySound(AudioClip audioClip, Vector3 position, float volumeMultiplier = 100f)
    {
        AudioSource.PlayClipAtPoint(audioClip, position, volumeMultiplier * volume);
    }
    private void OnDestroy()
    {
        DamageManager.Instance.OnIncrementringEnemyDamage -= DamageManager_OnIncrementringEnemyDamage;
        DamageManager.Instance.OnIncrementringPlayerDamage -= DamageManager_OnIncrementringPlayerDamage;
    }
}
