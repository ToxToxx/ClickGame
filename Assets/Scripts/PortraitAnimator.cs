using UnityEngine;

public class PortraitAnimator : MonoBehaviour
{
    private const string IS_GETTING_HIT = "IsGettingHit";

    private Animator _portraitAnimator;
    private readonly float _timerRange = 0.95f;

    [SerializeField] private HealthPoints gettingHitObject;

    void Start()
    {
        _portraitAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (DamageManager.Instance.GetAttackTimerNormalized() > _timerRange)
        {
            _portraitAnimator.SetBool(IS_GETTING_HIT, true);
        }
        else
        {
            _portraitAnimator.SetBool(IS_GETTING_HIT, false);
        }

    }
}
