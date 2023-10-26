using UnityEngine;

public class GoodTargetFactory : ITargetFactory
{
    private TargetPrefabsSO _targetPrefabs;

    public GoodTargetFactory(TargetPrefabsSO prefabs)
    {
        _targetPrefabs = prefabs;
    }

    public GameObject CreateTarget()
    {
        if (_targetPrefabs.goodPrefabs.Length > 0)
        {
            int randomIndex = Random.Range(0, _targetPrefabs.goodPrefabs.Length);
            GameObject target = GameObject.Instantiate(_targetPrefabs.goodPrefabs[randomIndex]);

            return target;
        }
        else
        {
            Debug.LogError("No Good Prefabs");
            return null;
        }
    }
}
