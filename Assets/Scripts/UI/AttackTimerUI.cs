using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class AttackTimerUI : MonoBehaviour
{
    [FormerlySerializedAs("timerImage")]
    [SerializeField] private Image _timerImage;

    private void Update()
    {
       _timerImage.fillAmount = DamageManager.Instance.GetAttackTimerNormalized();
    }
}
