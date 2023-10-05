using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnParameters : MonoBehaviour
{
    private Rigidbody targetRb;

    [SerializeField] private float spawnRate = 1.0f;
    [SerializeField] private float minSpeed = 12;
    [SerializeField] private float maxSpeed = 16;
    [SerializeField] private float maxTorque = 10;
    [SerializeField] private float xRange = 4;

    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();

    }


    void Update()
    {
        
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), SpawnManager.Instance.transform.position.y);
    }
}
