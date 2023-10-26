using UnityEngine;
using UnityEngine.Serialization;

public class Border : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;

    [FormerlySerializedAs("looseObjectDamage")]
    [SerializeField] private int _looseObjectDamage;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        if (other.gameObject.GetComponent<IncrementingPlayerDamage>())
        {
            _playerHealth.TakeDamage(_looseObjectDamage);
        }
    }
}
