using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitAnimator : MonoBehaviour
{
    private const string IS_GETTING_HIT = "IsGettingHit";
    private Animator portraitAnimator;

    private float timerRange = 0.95f;

    [SerializeField] private HealthPoints gettingHitObject;

    void Start()
    {
        portraitAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (DamageManager.Instance.GetAttackTimerNormalized() > timerRange)
        {
            portraitAnimator.SetBool(IS_GETTING_HIT, true);
        }
        else
        {
            portraitAnimator.SetBool(IS_GETTING_HIT, false);
        }

    }
}
