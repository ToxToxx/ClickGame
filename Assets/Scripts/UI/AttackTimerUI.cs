using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttackTimerUI : MonoBehaviour
{
    [SerializeField] private Image timerImage;

    private void Update()
    {
       timerImage.fillAmount = DamageManager.Instance.GetAttackTimerNormalized();
    }
}
