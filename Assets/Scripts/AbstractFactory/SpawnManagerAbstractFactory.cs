using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerAbstractFactory : MonoBehaviour
{
    public static SpawnManagerAbstractFactory Instance;

    [SerializeField] private TargetPrefabsSO _targetPrefabsSO;
    [SerializeField] private List<ITargetFactory> _targetFactories;

    private readonly float _spawnRate = 1f;

    private void Awake()
    {
        Instance = this;
        _targetFactories = new List<ITargetFactory>();
    }

    void Start()
    {
        _targetFactories.Add(new GoodTargetFactory(_targetPrefabsSO));
        _targetFactories.Add(new BadTargetFactory(_targetPrefabsSO));
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnRate);
            int index = UnityEngine.Random.Range(0, _targetFactories.Count);
            _targetFactories[index].CreateTarget();
        }
    }

    private void OnDestroy()
    {
        _targetFactories.Clear();
    }
}
