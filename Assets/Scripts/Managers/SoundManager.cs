using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private SoundEffectsSO audioClipRefsSO;
    private float _volume = 1.0f;

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
        AudioSource.PlayClipAtPoint(audioClip, position, volumeMultiplier * _volume);
    }
    private void OnDestroy()
    {
        DamageManager.Instance.OnIncrementringEnemyDamage -= DamageManager_OnIncrementringEnemyDamage;
        DamageManager.Instance.OnIncrementringPlayerDamage -= DamageManager_OnIncrementringPlayerDamage;
    }
}
