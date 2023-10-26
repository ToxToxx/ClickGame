using UnityEngine;
using UnityEngine.Serialization;

public class TargetParticle : MonoBehaviour
{
    [FormerlySerializedAs("explosionParticle")]
    [SerializeField] private ParticleSystem _explosionParticle;

    void OnDisable()
    {
        if (!this.gameObject.scene.isLoaded) return;
        Instantiate(_explosionParticle, transform.position, _explosionParticle.transform.rotation);
    }
}
