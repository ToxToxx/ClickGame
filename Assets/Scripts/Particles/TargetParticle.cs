using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosionParticle;

    private void OnDestroy()
    {
        if(Time.timeScale > 0)
        {
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }      
    }
}
