using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosionParticle;

    void OnDisable()
    {
        if (!this.gameObject.scene.isLoaded) return;
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
    }
}
