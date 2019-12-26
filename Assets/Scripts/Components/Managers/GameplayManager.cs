using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField]
    private CameraNextChunkGeneration _cameraTriggerHandler = null;

    private Chunk _currentChunk = null;

    void Start()
    {
        SpawnNextChunk();
    }

    private void OnEnable()
    {
        _cameraTriggerHandler.EventTriggerEntered += OnCameraEnteredNextChunkGenerationTrigger;
    }

    private void OnDisable()
    {
        _cameraTriggerHandler.EventTriggerEntered -= OnCameraEnteredNextChunkGenerationTrigger;
    }

    private void SpawnNextChunk()
    {
        var settingsManager = SettingsManager.Instance;
        int index = Random.Range(0, settingsManager.ChunkList.Count);
        var chunkPrefab = settingsManager.ChunkList[index];
        var newChunk = Instantiate(chunkPrefab);

        if (_currentChunk != null)
        {
            newChunk.transform.position = _currentChunk.NextChunkSpawnPoint.position;
            newChunk.transform.rotation = _currentChunk.NextChunkSpawnPoint.rotation;
        }
        else
        {
            newChunk.transform.position = Vector3.zero;
            newChunk.transform.rotation = Quaternion.identity;
        }

        _currentChunk = newChunk;
    }

    private void OnCameraEnteredNextChunkGenerationTrigger()
    {
        SpawnNextChunk();
    }

}
