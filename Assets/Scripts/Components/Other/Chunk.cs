using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public Transform NextChunkSpawnPoint { get { return _nextChunkSpawnPoint; } }

    [SerializeField]
    private List<Transform> _targetPositions = null;
    [SerializeField]
    private List<Transform> _wallPositions = null;
    [SerializeField]
    private List<Transform> _itemPositions = null;
    [SerializeField]
    private Transform _nextChunkSpawnPoint = null;

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

        foreach (var wallPosition in _wallPositions)
        {
            var settingsInstance = SettingsManager.Instance;
            int randomizedIndex = Random.Range(0, settingsInstance.WallPrefabs.Count);
            var wallPrefab = settingsInstance.WallPrefabs[randomizedIndex];

            var newObject = Instantiate(wallPrefab);

            newObject.transform.position = wallPosition.position;

            newObject.transform.SetParent(wallPosition);
        }

        foreach (var itemPosition in _itemPositions)
        {
            var settingsInstance = SettingsManager.Instance;
            int randomizedIndex = Random.Range(0, settingsInstance.ItemPrefabs.Count);
            var itemPrefab = settingsInstance.ItemPrefabs[randomizedIndex];

            var newObject = Instantiate(itemPrefab);

            newObject.transform.position = itemPosition.position;

            newObject.transform.SetParent(itemPosition);
        }
    }

}
