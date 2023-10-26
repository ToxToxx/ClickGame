using UnityEngine;
using UnityEngine.Serialization;

public class TargetSpawnParameters : MonoBehaviour
{
    private Rigidbody _targetRb;

    [FormerlySerializedAs("minSpeed")]
    [SerializeField] private float _minSpeed = 12;

    [FormerlySerializedAs("maxSpeed")]
    [SerializeField] private float _maxSpeed = 16;

    [FormerlySerializedAs("maxTorque")]
    [SerializeField] private float _maxTorque = 10;

    [FormerlySerializedAs("xRange")]
    [SerializeField] private float _xRange = 4;

    void Start()
    {
        _targetRb = GetComponent<Rigidbody>();
        _targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        _targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();

    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(_minSpeed, _maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-_maxTorque, _maxTorque);
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-_xRange, _xRange), SpawnManagerAbstractFactory.Instance.transform.position.y);
    }
}
