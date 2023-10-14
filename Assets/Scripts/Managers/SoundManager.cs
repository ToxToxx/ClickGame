using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private SoundEffectsSO audioClipRefsSO;
    private float _volume = 1.0f;

    private void Start()
    {
        
    }
    private void PlaySound(AudioClip audioClip, Vector3 position, float volumeMultiplier = 50f)
    {
        AudioSource.PlayClipAtPoint(audioClip, position, volumeMultiplier * _volume);
    }

}
