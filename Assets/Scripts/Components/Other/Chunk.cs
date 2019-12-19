using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField]
    private List<Transform> _targetPositions = null;

    private void Start()
    {
        foreach (var targetPosition in _targetPositions)
        {
            var settingsInstance = SettingsManager.Instance;
            int randomizedIndex = Random.Range(0, settingsInstance.TargetPrefabs.Count);
            var targetPrefab = settingsInstance.TargetPrefabs[randomizedIndex];

            var newObject = Instantiate(targetPrefab);

            newObject.transform.position = targetPosition.position;

            newObject.transform.SetParent(targetPosition);
        }
    }

}
