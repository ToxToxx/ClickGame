using UnityEngine;

public class BadTargetFactory : ITargetFactory
{
    private TargetPrefabsSO _targetPrefabs;

    public BadTargetFactory(TargetPrefabsSO prefabs)
    {
        _targetPrefabs = prefabs;
    }

    public GameObject CreateTarget()
    {
        if (_targetPrefabs.goodPrefabs.Length > 0)
        {
            int randomIndex = Random.Range(0, _targetPrefabs.badPrefabs.Length);
            GameObject target = GameObject.Instantiate(_targetPrefabs.badPrefabs[randomIndex]);

            return target;
        }
        else
        {
            Debug.LogError("No Bad Prefabs");
            return null;
        }
    }
}
